//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingSystemProject.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SODT_2
    {
        public int SodtID { get; set; }
        public int Sohd { get; set; }
        public string PF { get; set; }
        public string Lot { get; set; }
        public decimal BigNum { get; set; }
        public decimal StockNum { get; set; }
        public decimal PricePerOne { get; set; }
        public Nullable<int> Discount { get; set; }
        public string Pcode { get; set; }
        public string SodtCode { get; set; }
        public decimal Cost { get; set; }
        public string TagID { get; set; }
        public Nullable<int> Genmp { get; set; }
        public string Note { get; set; }
        public System.DateTime DeliveryDay { get; set; }
        public int Sunit { get; set; }
        public string Warehouse { get; set; }
        public string Storage { get; set; }
        public int NumberOder { get; set; }
        public string VatType { get; set; }
        public int VatRate { get; set; }
        public string PlaceDelivery { get; set; }
        public string ProductType { get; set; }
        public string SaleArea { get; set; }
        public string ClearStatus { get; set; }
        public string ClearNote { get; set; }
        public Nullable<System.DateTime> MutiDate { get; set; }
        public string CurrencyCode { get; set; }
        public string ExchangeCode { get; set; }
        public Nullable<int> ExchangeRate { get; set; }
    }
}