namespace Rocks
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mineral
    {
        [Key]
        public Guid MineralsId { get; set; }

        [Required]
        [StringLength(50)]
        public string MineralName { get; set; }

        [Required]
        [StringLength(50)]
        public string Formula { get; set; }

        [Required]
        [StringLength(50)]
        public string CrystalClass { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        [Required]
        [StringLength(50)]
        public string Habit { get; set; }
    }
}
