namespace DataBaseTest.DataEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Avtomobils
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nomer { get; set; }

        [StringLength(100)]
        public string Vladelec { get; set; }

        [StringLength(40)]
        public string Marka { get; set; }

        public int? Vozrast { get; set; }
    }
}
