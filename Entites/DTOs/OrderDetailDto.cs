using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.DTOs
{
    public class OrderDetailDto : IDto
    {
        public int OrderId { get; set; }
       
        public string ContactName { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
        public string ProductName { get; set; }

    }
}
