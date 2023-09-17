using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer.Dto
{
	public class OrderDetilDto
	{
        public int customerId { get; set; }
        public int orderId { get; set; }
        public int roomId { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set;}
        public DateTime orderDateTime { get; set; }
    }
}
