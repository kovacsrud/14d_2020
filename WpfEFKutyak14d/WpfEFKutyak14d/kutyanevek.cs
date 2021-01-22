namespace WpfEFKutyak14d
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kutyanevek")]
    public partial class kutyanevek
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kutyanevek()
        {
            kutya = new HashSet<kutya>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Kutyanev { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kutya> kutya { get; set; }
    }
}
