using CoderNextDoor.DataAccess.DataHelpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoderNextDoor.Data
{
    public class Comment : Entity
    {
        [Required]
        [Display(Name = "Body")]
        [StringLength(1000)]
        public string Body { get; set; }

        /// <summary>
        /// The userComment id.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The User.
        /// </summary>
        [ForeignKey("Id")]
        public User User { get; set; }

        /// <summary>
        /// CreatedDate Date currentDateTime
        /// <see cref="DateTime.Now"/> currentDateTime
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// The User.
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// CreatedDate Date currentDateTime
        /// <see cref="true"/> True
        /// </summary>
        public bool IsPublished { get; set; } = false;

        public Post Post { get; set; }
    }
}