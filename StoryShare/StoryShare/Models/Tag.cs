//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoryShare.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tag
    {
        public int id { get; set; }
        public string TagName { get; set; }
        public Nullable<int> StoryId { get; set; }
        public Nullable<int> AddedById { get; set; }
        public Nullable<System.DateTime> AddedOn { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
