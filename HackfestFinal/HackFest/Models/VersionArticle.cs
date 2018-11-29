using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HackFest.Models
{
    public class VersionArticle
    {
        [Key]
        public int ID_VersionArticle { get; set; }

        public string URL { get; set; }

        public decimal NoVersion { get; set; }

        public DateTime DateSoumission { get; set; }

        [ForeignKey("Article")]
        public int ID_Article { get; set; }

        public Article Article { get; set; }
    }
}
