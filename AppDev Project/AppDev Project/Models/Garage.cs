//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//asdas
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppDev_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Garage
    {
        public Garage()
        {
            this.Trucks = new HashSet<Truck>();
        }
    
        public string GarageID { get; set; }
        public string Adrs { get; set; }
        public string ConNum { get; set; }
        public string Size { get; set; }
        public decimal MCost { get; set; }
    
        public virtual ICollection<Truck> Trucks { get; set; }
    }
}
