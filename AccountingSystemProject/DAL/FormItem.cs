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
    
    public partial class FormItem
    {
        public int templateID { get; set; }
        public int sectionID { get; set; }
        public int id { get; set; }
        public string text { get; set; }
        public string tag { get; set; }
        public string datafield { get; set; }
        public Nullable<int> w { get; set; }
        public Nullable<int> h { get; set; }
        public Nullable<int> x { get; set; }
        public Nullable<int> y { get; set; }
        public Nullable<byte> TextAlign { get; set; }
        public Nullable<byte> BorderStyle { get; set; }
        public string BackColor { get; set; }
        public string ForeColor { get; set; }
        public string FontName { get; set; }
        public Nullable<byte> FontSize { get; set; }
        public Nullable<byte> FontUnit { get; set; }
        public string Bold { get; set; }
        public string UnderLine { get; set; }
        public string Strike { get; set; }
        public string Italic { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<int> fDigit { get; set; }
        public string fLead { get; set; }
        public string fParents { get; set; }
        public string fGroup { get; set; }
    }
}
