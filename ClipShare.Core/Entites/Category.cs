using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClipShare.Core.Entites
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        //navigations
        public ICollection<Video> Video { get; set; }
    }
}
