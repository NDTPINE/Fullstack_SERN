//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuaHangApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class InputInfo
    {
        public string InputInfos { get; set; }
        public string Goods { get; set; }
        public int NumberInput { get; set; }
        public float PricesInput { get; set; }
        public Nullable<float> Tax { get; set; }
    
        public virtual Good Good { get; set; }
        public virtual Input Input { get; set; }
    }
}