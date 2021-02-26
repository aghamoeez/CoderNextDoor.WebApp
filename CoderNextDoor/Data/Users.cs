using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoderNextDoor.Data
{
   public class  User : IdentityUser<int>
    {
    
        public User()
        {
            CreatedOn = DateTimeOffset.UtcNow;
        }
        public DateTimeOffset CreatedOn { get; set; }
        [StringLength(maximumLength: 256)]
        public string DisplayName { get; set; }

        public string AvatarUrl { get; set; }
    }
    public class Role : IdentityRole<int>
    {
    }

    public class Tag
    {

        [Key]
        public int TagId { get; set; }

        [Required]

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;


    }
    public class TagArticle
    {
        [Key]
        public int TagArticleId { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
    public class CommentArticle
    {
        [Key]
        public int CommentArticleId { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }


    }
    public class Comment
    {

        [Key]
        public int CommentId { get; set; }

        [Required]
        [Display(Name = "Context")]
        [StringLength(1000)]

        public string Context { get; set; }

        public string UserId { get; set; }
        [ForeignKey("Id")]
        public User User { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; set; } = true;
        public ICollection<CommentArticle> CommentArticle { get; set; }


    }
    public class Article
    {


        [Key]
        public int ArticleId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Abstract { get; set; }
        [Required]
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        public string AuthorId { get; set; }
        [ForeignKey("Id")]
        public User Author { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<CommentArticle> CommentArticle { get; set; }

    }


}
