using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ComputerGame : BaseEntity
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string Studio { get; set; }
    }
}
