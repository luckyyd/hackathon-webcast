﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using MStube.Common;
using MStube.Items;
using MStube.ViewModels;
using MStube.Utils;
using Newtonsoft.Json;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using Windows.Web.Http.Headers;
using Microsoft.HockeyApp;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MStube
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private VideoList listOfVideoBrief = VideoList.Instance;
        private DeviceInfo device = DeviceInfo.Instance;
        private long user_id = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        public async void InitializeValues()
        {
            LoadingProgressRing.IsActive = true;
            user_id = await GetUserId(this.device);
            List<VideoDetailItem> new_items = await GetVideoJson();
            new_items.Reverse();
            foreach (VideoDetailItem item in new_items)
            {
                listOfVideoBrief.Add(new VideoViewModel
                {
                    item_id = item.item_id,
                    Title = item.title,
                    ImageSourceUri = item.image_src,
                    VideoSourceUri = item.video_src,
                    Description = item.description,
                    FullDescription = item.full_description,
                    Views = item.views,
                    UploadDate = item.posted_time,
                    Brand = item.brand
                });
            }
            LoadingProgressRing.IsActive = false;
            VideoBriefList.ItemsSource = listOfVideoBrief.GetList();
        }

        private async Task<int> GetUserId(Utils.DeviceInfo device)
        {
            HttpClient httpClient = new HttpClient();
            var uuid = device.Id;
            var uri = new Uri("http://mstubedotnet.azurewebsites.net/api/userid?uuid=" + uuid);
            int user_id = 0;
            try
            {
                user_id = Int32.Parse(await httpClient.GetStringAsync(uri));
            }
            catch (Exception error)
            {
                Debug.WriteLine(error);
                HockeyClient.Current.TrackException(error);
            }
            finally
            {
                httpClient.Dispose();
            }
            HockeyClient.Current.TrackEvent("User: " + user_id.ToString());
            return user_id;
        }

        private async Task<List<VideoDetailItem>> GetVideoJson()
        {
            List<VideoDetailItem> items = new List<VideoDetailItem>();
            HttpClient httpClient = new HttpClient();
            // Cache-Control: private, to avoid load cache.
            var uri = new Uri("http://mstubedotnet.azurewebsites.net/api/Candidates?user_id=" + user_id.ToString() + "&t=" + new Random().Next(1, 1000).ToString());
            try
            {
                var result = await httpClient.GetStringAsync(uri);
                Debug.WriteLine("User id: " + user_id);
                Debug.WriteLine(result);
                items = JsonConvert.DeserializeObject<List<VideoDetailItem>>(result as string);
            }
            catch (Exception error)
            {
                Debug.WriteLine(error);
                HockeyClient.Current.TrackException(error);
            }
            finally
            {
                httpClient.Dispose();
            }
            return items;
        }

        private void ItemClicked(object sender, ItemClickEventArgs e)
        {
            VideoViewModel clickedItem = e.ClickedItem as VideoViewModel;
            clickedItem.user_id = user_id;
            Debug.WriteLine(clickedItem.item_id);
            HockeyClient.Current.TrackEvent("Item Clicked: " +clickedItem.item_id.ToString());
            Task.Run(()=>Utils.SendPreference.SendPreferenceToServer(clickedItem.user_id ,clickedItem.item_id, 4));
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(VideoPage), e.ClickedItem);
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            InitializeValues();
        }

        private void PullToRefreshBox_RefreshInvoked(DependencyObject sender, object args)
        {
            InitializeValues();
        }

        private async void SendFeedback_Click(object sender, RoutedEventArgs e)
        {
            //await Microsoft.Services.Store.Engagement.Feedback.LaunchFeedbackAsync();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }
    }
}
