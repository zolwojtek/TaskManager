//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int taskID { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
        public byte priority { get; set; }
        public byte status { get; set; }
    }
}
