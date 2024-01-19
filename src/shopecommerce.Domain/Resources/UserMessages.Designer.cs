﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace shopecommerce.Domain.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class UserMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UserMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("shopecommerce.Domain.Resources.UserMessages", typeof(UserMessages).Assembly);
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
        ///   Looks up a localized string similar to Chưa được cấp quyền để thực hiện yêu cầu này..
        /// </summary>
        public static string forbidden {
            get {
                return ResourceManager.GetString("forbidden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Không tìm thấy dữ liệu..
        /// </summary>
        public static string not_found {
            get {
                return ResourceManager.GetString("not_found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bạn chưa đăng nhập hoặc đã hết phiên làm việc..
        /// </summary>
        public static string unauthorized {
            get {
                return ResourceManager.GetString("unauthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email đã được đăng ký..
        /// </summary>
        public static string user_email_existed {
            get {
                return ResourceManager.GetString("user_email_existed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email không hợp lệ..
        /// </summary>
        public static string user_email_invalid {
            get {
                return ResourceManager.GetString("user_email_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thông tin User Id không hợp lệ..
        /// </summary>
        public static string user_id_is_invalid {
            get {
                return ResourceManager.GetString("user_id_is_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thông tin người dùng không tồn tại..
        /// </summary>
        public static string user_id_is_not_existed {
            get {
                return ResourceManager.GetString("user_id_is_not_existed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thiếu thông tin User Id..
        /// </summary>
        public static string user_id_is_required {
            get {
                return ResourceManager.GetString("user_id_is_required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tài khoản đã tồn tại..
        /// </summary>
        public static string user_name_existed {
            get {
                return ResourceManager.GetString("user_name_existed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tên tài khoản không hợp lệ..
        /// </summary>
        public static string user_name_invalid {
            get {
                return ResourceManager.GetString("user_name_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mật khẩu không hợp lệ..
        /// </summary>
        public static string user_password_invalid {
            get {
                return ResourceManager.GetString("user_password_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại đã được đăng ký..
        /// </summary>
        public static string user_phone_number_is_existed {
            get {
                return ResourceManager.GetString("user_phone_number_is_existed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Số điện thoại không tồn tại..
        /// </summary>
        public static string user_phone_number_is_not_existed {
            get {
                return ResourceManager.GetString("user_phone_number_is_not_existed", resourceCulture);
            }
        }
    }
}
