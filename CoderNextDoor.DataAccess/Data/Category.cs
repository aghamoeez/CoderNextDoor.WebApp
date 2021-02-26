using CoderNextDoor.DataAccess.DataHelpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderNextDoor.Data
{
    /// <summary>
    /// A blog category.
    /// </summary>
    public partial class Category : Entity
    {
        /// <summary>
        /// Text of the term.
        /// </summary>
        [Required]
        [StringLength(maximumLength: 256)]
        public string Title { get; set; }

        /// <summary>
        /// Friendly url of the term.
        /// </summary>
        [Required]
        [StringLength(maximumLength: 256)]
        public string Slug { get; set; }

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

        public DateTime CretedDate { get; set; } = DateTime.Now;
        public DateTime ModifiyDate { get; set; }
    }
}