﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vidly.Migrations {
    using System;
    
    
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, formatting them, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilderEx class via the ResXFileCodeGeneratorEx custom tool.
    // To add or remove a member, edit your .ResX file then rerun the ResXFileCodeGeneratorEx custom tool or rebuild your VS.NET project.
    // Copyright (c) Dmytro Kryvko 2006-2021 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("DMKSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "3.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
#if !SILVERLIGHT
    [global::System.Reflection.ObfuscationAttribute(Exclude=true, ApplyToMembers=true)]
#endif
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public partial class _202104201914461_AddIsSubscribedToCustomer {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        /// <summary>
        /// Initializes a 202104201914461_AddIsSubscribedToCustomer object.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public _202104201914461_AddIsSubscribedToCustomer() {
        }
        
        /// <summary>
        /// Thread safe lock object used by this class.
        /// </summary>
        public static object InternalSyncObject {
            get {
                if (object.ReferenceEquals(_internalSyncObject, null)) {
                    global::System.Threading.Interlocked.CompareExchange(ref _internalSyncObject, new object(), null);
                }
                return _internalSyncObject;
            }
        }
        
        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(_resourceManager, null)) {
                    global::System.Threading.Monitor.Enter(InternalSyncObject);
                    try {
                        if (object.ReferenceEquals(_resourceManager, null)) {
                            global::System.Threading.Interlocked.Exchange(ref _resourceManager, new global::System.Resources.ResourceManager("Vidly.Migrations.202104201914461_AddIsSubscribedToCustomer", typeof(_202104201914461_AddIsSubscribedToCustomer).Assembly));
                        }
                    }
                    finally {
                        global::System.Threading.Monitor.Exit(InternalSyncObject);
                    }
                }
                return _resourceManager;
            }
        }
        
        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return _resourceCulture;
            }
            set {
                _resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'dbo'.
        /// </summary>
        public static string DefaultSchema {
            get {
                return ResourceManager.GetString(ResourceNames.DefaultSchema, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'H4sIAAAAAAAEAN1c227kNhJ9X2D/QdDT7sJp+ZIZzBrdCZy2nRjrG6Y9g30bsCV2WxiJUkTKY2ORL8tDPim/EFKibrxIVLf6thhgYInFU8WqIlmkqvrP3/8Y//gaBtYLTLAfoYl9Mjq2LYjcyPPRcmKnZPHdB/vHH/7+t/GVF75anwu6M0ZHeyI8sZ8Jic8dB7vPMAR4FPpuEuFoQUZuFDrAi5zT4+N/OycnDqQQNsWyrPHHFBE/hNkDfZxGyIUxSUFwF3kwwPw9bZllqNY9CCGOgQsn9mffC95GOZ1tXQQ+oDLMYLCwLYBQRAChEp5/wnBGkggtZzF9AYKntxhSugUIMOSSn1fkpoM4PmWDcKqOBZSbYhKFPQFPzrhWHLH7Srq1S61RvV1R/ZI3NupMdxN7mrGAiW2JzM6nQcIIm6odFR2OrOz1UWl86iPs35E1TQOSJnCCYEoSEBxZj+k88N3/wLen6CtEE5QGQV0oKhZta7ygrx6TKIYJefsIF1zU [rest of string was truncated]&quot;;'.
        /// </summary>
        public static string Target {
            get {
                return ResourceManager.GetString(ResourceNames.Target, _resourceCulture);
            }
        }
        
        /// <summary>
        /// Lists all the resource names as constant string fields.
        /// </summary>
        public class ResourceNames {
            
            /// <summary>
            /// Stores the resource name 'DefaultSchema'.
            /// </summary>
            public const string DefaultSchema = "DefaultSchema";
            
            /// <summary>
            /// Stores the resource name 'Target'.
            /// </summary>
            public const string Target = "Target";
        }
    }
}
