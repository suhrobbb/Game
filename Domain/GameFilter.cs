using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GameFilter : BaseEntity
    {
        public int MinReleaseYear { get; set; }
        public int MaxReleaseYear { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
    }
}
