﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mstube.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mstube-dotnet-id.redis.cache.windows.net,abortConnect=false,ssl=true,password=Tp/" +
            "f4EEuKJWK1z7HJOvyrvZrg5IA9y4/W9BELvUPWZg=")]
        public string RedisUserId {
            get {
                return ((string)(this["RedisUserId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mstube-dotnet-filter.redis.cache.windows.net,abortConnect=false,ssl=true,password" +
            "=K6Cxw7qz8TEWmvCdApIck+bQKHnc3+t8Z2SYw5xqOd8=")]
        public string RedisPostHistory {
            get {
                return ((string)(this["RedisPostHistory"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mstube-dotnet.redis.cache.windows.net,abortConnect=false,ssl=true,password=6/Cq0R" +
            "6Wh+L6PJeYI80KEMVyYVGUjqZFEnNS6iJHl1A=")]
        public string RedisLastItem {
            get {
                return ((string)(this["RedisLastItem"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nG0MPtLcKCMPj15uKalobeFWvfLNljGen/K21qcbLdxrPtdW/UWViA4xuqEJPvb9O+FoAd7BIXgFxLSlu" +
            "WAM5g==")]
        public string StorageAccountKey {
            get {
                return ((string)(this["StorageAccountKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TrainingInputdatablob.csv")]
        public string StorageInputBlobName {
            get {
                return ((string)(this["StorageInputBlobName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://asiasoutheast.services.azureml.net/workspaces/0cd16c9abdb94e249ae6f6fb27b" +
            "76402/services/18b53af654d44315be711d9386e32afb/execute?api-version=2.0&details=" +
            "true")]
        public string AzureMLContentBasedUri {
            get {
                return ((string)(this["AzureMLContentBasedUri"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://asiasoutheast.services.azureml.net/workspaces/0cd16c9abdb94e249ae6f6fb27b" +
            "76402/services/cc0f591208854390b93d137a1098d034/execute?api-version=2.0&details=" +
            "true")]
        public string AzureMLCollaborativeFilterUri {
            get {
                return ((string)(this["AzureMLCollaborativeFilterUri"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FLrpT2xb8hRFQ+Ot2BVL3B3cep/hUUIx/hnYF5RIVVMsDujyymaMTTwQJ2lNbJBlQINy/vBegJvfT99qv" +
            "PvoTA==")]
        public string AzureMLContentBasedApiKey {
            get {
                return ((string)(this["AzureMLContentBasedApiKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("wDJrd0QXCPH7bo6r0a+3zKjdSpnvMxw8LZp0wTMvdDVeslUmdDohgbwylT+7oOQLQBx/TDe8K2O8ujGf2" +
            "fz8sw==")]
        public string AzureMLCollaborativeFilterApiKey {
            get {
                return ((string)(this["AzureMLCollaborativeFilterApiKey"]));
            }
        }
    }
}
