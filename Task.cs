//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace taskmange
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int TaskID { get; set; }
        public string Task_Title { get; set; }
        public string Task_Description { get; set; }
        public string Task_Status { get; set; }
        public Nullable<System.DateTime> Task_DueDate { get; set; }
        public string Employee_name { get; set; }
    }
}
