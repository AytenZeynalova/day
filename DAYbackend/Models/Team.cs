using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAYbackend.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Img { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Desc { get; set; }
        
        public string TwttrUrl { get; set; }
        public string FbUrl { get; set; }
        public string InstaUrl { get; set; }
        public string LinkdnUrl { get; set; }





    }
}
