//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_CURD_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Employee_Master
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip_Code { get; set; }
        public bool Active_Status { get; set; }
    
        public virtual tbl_Educational_Details tbl_Educational_Details { get; set; }
    }
}
