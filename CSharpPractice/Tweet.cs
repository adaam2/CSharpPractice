namespace CSharpPractice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tweet
    {
        public Tweet()
        {
            EntityTweetLinks = new HashSet<EntityTweetLink>();
        }

        public int ID { get; set; }

        [Required]
        public string tweetEncodedText { get; set; }

        public DateTime tweetDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string tweetUserHandle { get; set; }

        public double tweetLatitude { get; set; }

        public double tweetLongitude { get; set; }

        [Required]
        public string tweetUserProfileImageUrl { get; set; }

        public virtual ICollection<EntityTweetLink> EntityTweetLinks { get; set; }
    }
}
