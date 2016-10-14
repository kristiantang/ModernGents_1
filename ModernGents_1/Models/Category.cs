using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernGents_1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Posts> Posts { get; set; }
    }
}