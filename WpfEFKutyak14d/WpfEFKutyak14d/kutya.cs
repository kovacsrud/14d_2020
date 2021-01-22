namespace WpfEFKutyak14d
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kutya")]
    public partial class kutya
    {
        public int Id { get; set; }

        public int fajtaid { get; set; }

        public int nevid { get; set; }

        public int kor { get; set; }

        [Required]
        [StringLength(50)]
        public string utolsokezeles { get; set; }

        public virtual kutyafajtak kutyafajtak { get; set; }

        public virtual kutyanevek kutyanevek { get; set; }
    }
}
