﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Desktop.Help {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class HelpSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static HelpSettings defaultInstance = ((HelpSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new HelpSettings())));
        
        public static HelpSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Path to user guide
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Path to user guide")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserGuidePath {
            get {
                return ((string)(this["UserGuidePath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://clearcanvas.github.io")]
        public string WebsiteUrl {
            get {
                return ((string)(this["WebsiteUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("License.rtf")]
        public string LicenseDocument {
            get {
                return ((string)(this["LicenseDocument"]));
            }
        }
    }
}
