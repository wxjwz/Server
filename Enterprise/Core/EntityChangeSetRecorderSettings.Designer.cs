﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Enterprise.Core {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class EntityChangeSetRecorderSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static EntityChangeSetRecorderSettings defaultInstance = ((EntityChangeSetRecorderSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new EntityChangeSetRecorderSettings())));
        
        public static EntityChangeSetRecorderSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// Enables or disables change-set recording in the audit logs.  A restart is required for modifications to this setting to take effect.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Enables or disables change-set recording in the audit logs.  A restart is require" +
            "d for modifications to this setting to take effect.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableRecording {
            get {
                return ((bool)(this["EnableRecording"]));
            }
        }
    }
}
