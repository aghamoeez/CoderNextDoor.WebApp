using CoderNextDoor.DataAccess.DataHelpers;
using CoderNextDoor.DataAccess.HelperServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderNextDoor.Data
{
    public class Tag : Entity
    {
        public Tag()
        {
            Color = HelperServices.RandomColorCode();//Get Random Color
                                                     //     PostTags = new HashSet<PostTag>();
        }

        /// <summary>
        /// Text of the term.
        /// </summary>
        [Required]
        [StringLength(maximumLength: 256)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the category.
        /// </summary>
        /// <remarks>
        /// No html allowed, this field is HtmlEncoded.
        /// </remarks>
        public string Description { get; set; }

        /// <summary>
        /// Published post count.
        /// </summary>
        [NotMapped]
        public int Count { get; set; }

        [StringLength(32)]
        public string Color { get; set; }

        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Friendly url of the term.
        /// </summary>
        [Required]
        [StringLength(maximumLength: 256)]
        public string Slug { get; set; }

        //  [NotMapped]
        // public string RelativeLink => BlogRoutes.GetTagRelativeLink(Slug);

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}