using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTOs
{
    public class AuthorsGenreStat
    {
        public string AuthorName { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int BookCount { get; set; }
    }
}
