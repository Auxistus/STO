//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementSystem.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Component
    {
        public int ProductID { get; set; }
        public int ComponentID { get; set; }
        public short Quantity { get; set; }
        public System.DateTime Created { get; set; }
    
        public virtual Component Component { get; set; }
        public virtual Product Product { get; set; }
    }
}