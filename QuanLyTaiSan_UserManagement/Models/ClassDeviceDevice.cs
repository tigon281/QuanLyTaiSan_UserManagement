﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTaiSan_UserManagement.Models
{
    using System;

    public partial class ChildrenOfDevice
    {
        public int Id { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string Configuration { get; set; }
        public Nullable<double> Price { get; set; }
        public string PurchaseContract { get; set; }
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> StatusRepair { get; set; }
        public string TypeName { get; set; }
        public Nullable<int> DeviceCodeParents { get; set; }
        public Nullable<int> DeviceCodeChildren { get; set; }
        public Nullable<int> TypeSymbolParents { get; set; }
        public Nullable<int> TypeSymbolChildren { get; set; }
        public Array numbers { get; set; }
    }
}
