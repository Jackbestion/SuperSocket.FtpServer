﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperSocket.Ftp.FtpService {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SuperSocket.Ftp.FtpService.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 226 ABOR command successful..
        /// </summary>
        public static string AbortOk_226 {
            get {
                return ResourceManager.GetString("AbortOk_226", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 202 Command ACCT not implemented, superfluous at this site..
        /// </summary>
        public static string AcctOk_220 {
            get {
                return ResourceManager.GetString("AcctOk_220", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 230 Already logged-in..
        /// </summary>
        public static string AlreadyLoggedIn_230 {
            get {
                return ResourceManager.GetString("AlreadyLoggedIn_230", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 530 Authentication failed..
        /// </summary>
        public static string AuthenticationFailed_530 {
            get {
                return ResourceManager.GetString("AuthenticationFailed_530", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 234 AUTH Command OK. Initializing {0} connection..
        /// </summary>
        public static string AuthOk_234 {
            get {
                return ResourceManager.GetString("AuthOk_234", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 Can&apos;t remove directory {0}. It is a system directory..
        /// </summary>
        public static string CannotRemoveSystemDirectory_550 {
            get {
                return ResourceManager.GetString("CannotRemoveSystemDirectory_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 553 Can&apos;t rename directory {0}. It is a system directory..
        /// </summary>
        public static string CannotRenameSystemDirectory_553 {
            get {
                return ResourceManager.GetString("CannotRenameSystemDirectory_553", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 250 Directory changed to {0}..
        /// </summary>
        public static string ChangeDirectoryUp_250 {
            get {
                return ResourceManager.GetString("ChangeDirectoryUp_250", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 250 Folder changed to &quot;{0}&quot;..
        /// </summary>
        public static string ChangeWorkDirOk_250 {
            get {
                return ResourceManager.GetString("ChangeWorkDirOk_250", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 257 &quot;{0}&quot; is current directory..
        /// </summary>
        public static string CurrentDirectory_257 {
            get {
                return ResourceManager.GetString("CurrentDirectory_257", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 150 Connection accepted..
        /// </summary>
        public static string DataConnectionAccepted_150 {
            get {
                return ResourceManager.GetString("DataConnectionAccepted_150", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 420 Can&apos;t open data connection..
        /// </summary>
        public static string DataConnectionCannotOpen_420 {
            get {
                return ResourceManager.GetString("DataConnectionCannotOpen_420", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 426 Data connection error..
        /// </summary>
        public static string DataConnectionError_426 {
            get {
                return ResourceManager.GetString("DataConnectionError_426", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 226 Transfer complete..
        /// </summary>
        public static string DataTransferComplete_226 {
            get {
                return ResourceManager.GetString("DataTransferComplete_226", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 450 Can&apos;t delete file {0}..
        /// </summary>
        public static string DeleteFailed_450 {
            get {
                return ResourceManager.GetString("DeleteFailed_450", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 250 file deleted..
        /// </summary>
        public static string DeleteOk_250 {
            get {
                return ResourceManager.GetString("DeleteOk_250", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 {0}: The directory already exists..
        /// </summary>
        public static string DirectoryAlreadyExist_550 {
            get {
                return ResourceManager.GetString("DirectoryAlreadyExist_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 211-Extensions supported:
        ///SIZE
        ///MLSD
        ///MLST
        ///NLST
        ///MDTM
        ///REST STREAM
        ///UTF8
        ///211 END.
        /// </summary>
        public static string FeaturesOk_221 {
            get {
                return ResourceManager.GetString("FeaturesOk_221", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 213 {0}.
        /// </summary>
        public static string FileOk_213 {
            get {
                return ResourceManager.GetString("FileOk_213", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 450 File system error..
        /// </summary>
        public static string FileSystemError_450 {
            get {
                return ResourceManager.GetString("FileSystemError_450", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 {0}: File unavailable..
        /// </summary>
        public static string FileUnavailable_550 {
            get {
                return ResourceManager.GetString("FileUnavailable_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 220 Welcome SuperSocket FTP Server.
        /// </summary>
        public static string FTP_Welcome {
            get {
                return ResourceManager.GetString("FTP_Welcome", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 221 Goodbye..
        /// </summary>
        public static string GoodBye_221 {
            get {
                return ResourceManager.GetString("GoodBye_221", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 551 {0}: Error on input file..
        /// </summary>
        public static string InputFileError_551 {
            get {
                return ResourceManager.GetString("InputFileError_551", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 501 Syntax error in parameters or arguments..
        /// </summary>
        public static string InvalidArguments_501 {
            get {
                return ResourceManager.GetString("InvalidArguments_501", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 230 User logged in, proceed..
        /// </summary>
        public static string LoggedIn_230 {
            get {
                return ResourceManager.GetString("LoggedIn_230", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 Can&apos;t create directory {0}..
        /// </summary>
        public static string MakeDirFailed_550 {
            get {
                return ResourceManager.GetString("MakeDirFailed_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 250 &quot;{0}&quot; created..
        /// </summary>
        public static string MakeDirOk_250 {
            get {
                return ResourceManager.GetString("MakeDirOk_250", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 200 Command NOOP okay..
        /// </summary>
        public static string NoopOk_200 {
            get {
                return ResourceManager.GetString("NoopOk_200", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 No such file or directory..
        /// </summary>
        public static string NotFound_550 {
            get {
                return ResourceManager.GetString("NotFound_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 {0}: No such file or directory..
        /// </summary>
        public static string NotFoundWithPath_550 {
            get {
                return ResourceManager.GetString("NotFoundWithPath_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 502 Command not implemented..
        /// </summary>
        public static string NotImplement_502 {
            get {
                return ResourceManager.GetString("NotImplement_502", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 551 Error on output file..
        /// </summary>
        public static string OuputFileError_551 {
            get {
                return ResourceManager.GetString("OuputFileError_551", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 552 Requested file action aborted. Exceeded storage allocation..
        /// </summary>
        public static string OutOfStorage_552 {
            get {
                return ResourceManager.GetString("OutOfStorage_552", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 227 Entering Passive Mode ({0})..
        /// </summary>
        public static string PassiveEnter_227 {
            get {
                return ResourceManager.GetString("PassiveEnter_227", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 200 Command PBSZ okay..
        /// </summary>
        public static string PBSZ_200 {
            get {
                return ResourceManager.GetString("PBSZ_200", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 Permission denied..
        /// </summary>
        public static string PermissionDenied_550 {
            get {
                return ResourceManager.GetString("PermissionDenied_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 552 Not a valid port number..
        /// </summary>
        public static string PortInvalid_552 {
            get {
                return ResourceManager.GetString("PortInvalid_552", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 220 Command PORT okay..
        /// </summary>
        public static string PortOk_220 {
            get {
                return ResourceManager.GetString("PortOk_220", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 431 Security is disabled..
        /// </summary>
        public static string ProtDisabled_431 {
            get {
                return ResourceManager.GetString("ProtDisabled_431", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 504 Server does not understand the specified protection level..
        /// </summary>
        public static string ProtectionLevelUnknow_504 {
            get {
                return ResourceManager.GetString("ProtectionLevelUnknow_504", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 200 Command PROT okay..
        /// </summary>
        public static string ProtOk_200 {
            get {
                return ResourceManager.GetString("ProtOk_200", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 421 Maximum login limit has been reached..
        /// </summary>
        public static string ReachedLoginLimit_421 {
            get {
                return ResourceManager.GetString("ReachedLoginLimit_421", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 550 Can&apos;t remove directory {0}..
        /// </summary>
        public static string RemoveDirectoryFailed_550 {
            get {
                return ResourceManager.GetString("RemoveDirectoryFailed_550", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 250 &quot;{0}&quot; removed..
        /// </summary>
        public static string RemoveOk_250 {
            get {
                return ResourceManager.GetString("RemoveOk_250", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 553 Failed to rename this directory..
        /// </summary>
        public static string RenameDirectoryFailed_553 {
            get {
                return ResourceManager.GetString("RenameDirectoryFailed_553", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 350 Requested file action pending further information..
        /// </summary>
        public static string RenameForOk_350 {
            get {
                return ResourceManager.GetString("RenameForOk_350", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 553 Can&apos;t rename file..
        /// </summary>
        public static string RenameToFailed_553 {
            get {
                return ResourceManager.GetString("RenameToFailed_553", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 250 Requested file action okay, file renamed..
        /// </summary>
        public static string RenameToOk_250 {
            get {
                return ResourceManager.GetString("RenameToOk_250", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 331 Password required for {0}..
        /// </summary>
        public static string RequirePasswor_331 {
            get {
                return ResourceManager.GetString("RequirePasswor_331", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 350 Restarting at {0}..
        /// </summary>
        public static string RestartOk_350 {
            get {
                return ResourceManager.GetString("RestartOk_350", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 213 {0}.
        /// </summary>
        public static string SizeOk_213 {
            get {
                return ResourceManager.GetString("SizeOk_213", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 200 Type set to {0}..
        /// </summary>
        public static string TypeOk_220 {
            get {
                return ResourceManager.GetString("TypeOk_220", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 450 Unknown error..
        /// </summary>
        public static string UnknownError_450 {
            get {
                return ResourceManager.GetString("UnknownError_450", resourceCulture);
            }
        }
    }
}
