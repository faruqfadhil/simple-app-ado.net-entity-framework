//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sembarangKasir
{
    using System;
    using System.Collections.Generic;
    
    public partial class master_barang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public master_barang()
        {
            this.master_restock = new HashSet<master_restock>();
            this.transaksi = new HashSet<transaksi>();
        }
    
        public int id { get; set; }
        public string nama_barang { get; set; }
        public string jenis_barang { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<int> harga { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<master_restock> master_restock { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaksi> transaksi { get; set; }
    }
}
