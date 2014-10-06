namespace CSharpPractice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EntityTweetLink")]
    public partial class EntityTweetLink
    {
        public int ID { get; set; }

        public int entityID { get; set; }

        public int tweetID { get; set; }

        public virtual Entity Entity { get; set; }

        public virtual Tweet Tweet { get; set; }
    }
}
