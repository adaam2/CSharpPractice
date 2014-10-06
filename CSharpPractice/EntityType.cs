namespace CSharpPractice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EntityType
    {
        public EntityType()
        {
            Entities = new HashSet<Entity>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string entityTypeName { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
    }
}
