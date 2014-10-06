namespace CSharpPractice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entity
    {
        public Entity()
        {
            EntityTweetLinks = new HashSet<EntityTweetLink>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string entityName { get; set; }

        public DateTime lastUpdated { get; set; }

        public double? averageCenterLatitude { get; set; }

        public double? averageCenterLongitude { get; set; }

        public int? entityTypeID { get; set; }

        public virtual EntityType EntityType { get; set; }

        public virtual ICollection<EntityTweetLink> EntityTweetLinks { get; set; }
    }
}
