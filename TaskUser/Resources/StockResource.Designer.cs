﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskUser.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class StockResource {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StockResource() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("TaskUser.Resources.StockResource", typeof(StockResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string lbl_StockManage {
            get {
                return ResourceManager.GetString("lbl_StockManage", resourceCulture);
            }
        }
        
        public static string lbl_AddStock {
            get {
                return ResourceManager.GetString("lbl_AddStock", resourceCulture);
            }
        }
        
        public static string lbl_EditStock {
            get {
                return ResourceManager.GetString("lbl_EditStock", resourceCulture);
            }
        }
        
        public static string btn_AddNewStock {
            get {
                return ResourceManager.GetString("btn_AddNewStock", resourceCulture);
            }
        }
        
        public static string lbl_StoreId {
            get {
                return ResourceManager.GetString("lbl_StoreId", resourceCulture);
            }
        }
        
        public static string lbl_ProductId {
            get {
                return ResourceManager.GetString("lbl_ProductId", resourceCulture);
            }
        }
        
        public static string lbl_Quantity {
            get {
                return ResourceManager.GetString("lbl_Quantity", resourceCulture);
            }
        }
        
        public static string btn_Edit {
            get {
                return ResourceManager.GetString("btn_Edit", resourceCulture);
            }
        }
        
        public static string lbl_manipulation {
            get {
                return ResourceManager.GetString("lbl_manipulation", resourceCulture);
            }
        }
        
        public static string btn_AddNewCategory {
            get {
                return ResourceManager.GetString("btn_AddNewCategory", resourceCulture);
            }
        }
        
        public static string err_AddFailure {
            get {
                return ResourceManager.GetString("err_AddFailure", resourceCulture);
            }
        }
        
        public static string err_EditFailure {
            get {
                return ResourceManager.GetString("err_EditFailure", resourceCulture);
            }
        }
        
        public static string msg_NotEmpty {
            get {
                return ResourceManager.GetString("msg_NotEmpty", resourceCulture);
            }
        }
        
        public static string msg_NumberMustBeGreaterThanOrEqualToOne {
            get {
                return ResourceManager.GetString("msg_NumberMustBeGreaterThanOrEqualToOne", resourceCulture);
            }
        }
    }
}