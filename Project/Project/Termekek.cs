//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Termekek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Termekek()
        {
            this.Arak = new HashSet<Arak>();
            this.Ertekelesek = new HashSet<Ertekelesek>();
        }
    
        public int TermekID { get; set; }
        public int GyartoFK { get; set; }
        public string Nev { get; set; }
        public Nullable<bool> DualSIM { get; set; }
        public string Oprendszer { get; set; }
        public string Processzor_tipusa { get; set; }
        public Nullable<int> RAM { get; set; }
        public Nullable<int> Belso_memoria { get; set; }
        public Nullable<bool> Bovitheto { get; set; }
        public Nullable<float> Kijelzo_merete { get; set; }
        public string Kijelzo_tipusa { get; set; }
        public Nullable<int> Akku_kapacitas { get; set; }
        public Nullable<float> Hosszusag { get; set; }
        public Nullable<float> Szelesseg { get; set; }
        public Nullable<float> Vastagsag { get; set; }
        public Nullable<float> Tomeg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arak> Arak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ertekelesek> Ertekelesek { get; set; }
        public virtual Gyartok Gyartok { get; set; }
    }
}
