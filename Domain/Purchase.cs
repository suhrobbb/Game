using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Purchase : BaseEntity
    {
        public ComputerGame Game { get; set; }
        public User User { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
