using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ModernGents_1.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public int ImageId { get; set; }
        [ForeignKey("ImageId")]
        public virtual Image Image { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}