﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8670
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FolderWatcher.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute(" SERVER=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.10.160)(PORT=1580))(CON" +
            "NECT_DATA=(SERVICE_NAME=apps))); uid=hnba_crc;pwd=HNBACRC;")]
        public string DBConString {
            get {
                return ((string)(this["DBConString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS\\NEW\\")]
        public string PathNewBusiness {
            get {
                return ((string)(this["PathNewBusiness"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS\\RENEWAL\\")]
        public string PathRenewal {
            get {
                return ((string)(this["PathRenewal"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS\\ENDORSEMENT\\")]
        public string PathEndorsement {
            get {
                return ((string)(this["PathEndorsement"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS\\CANCELLATION\\")]
        public string PathCancellation {
            get {
                return ((string)(this["PathCancellation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\QUEUED_SCN_DOCS\\NEW\\")]
        public string PathQueuedNewBusiness {
            get {
                return ((string)(this["PathQueuedNewBusiness"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\QUEUED_SCN_DOCS\\RENEWAL\\")]
        public string PathQueuedRenewal {
            get {
                return ((string)(this["PathQueuedRenewal"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\QUEUED_SCN_DOCS\\ENDORSEMENT\\")]
        public string PathQueuedEndorsement {
            get {
                return ((string)(this["PathQueuedEndorsement"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\QUEUED_SCN_DOCS\\CANCELLATION\\")]
        public string PathQueuedCancellation {
            get {
                return ((string)(this["PathQueuedCancellation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\LOGS\\log_of_")]
        public string LogFileName {
            get {
                return ((string)(this["LogFileName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TCS")]
        public string SYSTEM_NAME_TCS {
            get {
                return ((string)(this["SYSTEM_NAME_TCS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Takaful")]
        public string SYSTEM_NAME_TAKAFUL {
            get {
                return ((string)(this["SYSTEM_NAME_TAKAFUL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\UNKNOWN_SCN_DOCS\\NEW\\")]
        public string PathUnknownNewBusiness {
            get {
                return ((string)(this["PathUnknownNewBusiness"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\UNKNOWN_SCN_DOCS\\RENEWAL\\")]
        public string PathUnknownRenewal {
            get {
                return ((string)(this["PathUnknownRenewal"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\UNKNOWN_SCN_DOCS\\ENDORSEMENT\\")]
        public string PathUnknownEndorsement {
            get {
                return ((string)(this["PathUnknownEndorsement"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\UNKNOWN_SCN_DOCS\\CANCELLATION\\")]
        public string PathUnknownCancellation {
            get {
                return ((string)(this["PathUnknownCancellation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Invalid Job No")]
        public string UnknownInvalidJobNo {
            get {
                return ((string)(this["UnknownInvalidJobNo"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Already Completed Job")]
        public string UnknownAlreadyCompletedJob {
            get {
                return ((string)(this["UnknownAlreadyCompletedJob"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("File Error")]
        public string UnknownFileError {
            get {
                return ((string)(this["UnknownFileError"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_2\\NEW\\")]
        public string PathNewBusiness2 {
            get {
                return ((string)(this["PathNewBusiness2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_2\\RENEWAL\\")]
        public string PathRenewal2 {
            get {
                return ((string)(this["PathRenewal2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_2\\ENDORSEMENT\\")]
        public string PathEndorsement2 {
            get {
                return ((string)(this["PathEndorsement2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_2\\CANCELLATION\\")]
        public string PathCancellation2 {
            get {
                return ((string)(this["PathCancellation2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_3\\NEW\\")]
        public string PathNewBusiness3 {
            get {
                return ((string)(this["PathNewBusiness3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_3\\RENEWAL\\")]
        public string PathRenewal3 {
            get {
                return ((string)(this["PathRenewal3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_3\\ENDORSEMENT\\")]
        public string PathEndorsement3 {
            get {
                return ((string)(this["PathEndorsement3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_3\\CANCELLATION\\")]
        public string PathCancellation3 {
            get {
                return ((string)(this["PathCancellation3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_4\\NEW\\")]
        public string PathNewBusiness4 {
            get {
                return ((string)(this["PathNewBusiness4"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_4\\RENEWAL\\")]
        public string PathRenewal4 {
            get {
                return ((string)(this["PathRenewal4"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_4\\ENDORSEMENT\\")]
        public string PathEndorsement4 {
            get {
                return ((string)(this["PathEndorsement4"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_4\\CANCELLATION\\")]
        public string PathCancellation4 {
            get {
                return ((string)(this["PathCancellation4"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS\\NEWFST\\")]
        public string PathNewBusinessFST1 {
            get {
                return ((string)(this["PathNewBusinessFST1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_2\\NEWFST\\")]
        public string PathNewBusinessFST2 {
            get {
                return ((string)(this["PathNewBusinessFST2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_3\\NEWFST\\")]
        public string PathNewBusinessFST3 {
            get {
                return ((string)(this["PathNewBusinessFST3"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\SCN_DOCS_4\\NEWFST\\")]
        public string PathNewBusinessFST4 {
            get {
                return ((string)(this["PathNewBusinessFST4"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\QUEUED_SCN_DOCS\\NEWFST\\")]
        public string PathQueuedNewBusinessFST {
            get {
                return ((string)(this["PathQueuedNewBusinessFST"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("E:\\HNBGI\\UNKNOWN_SCN_DOCS\\NEWFST\\")]
        public string PathUnknownNewBusinessFST {
            get {
                return ((string)(this["PathUnknownNewBusinessFST"]));
            }
        }
    }
}
