using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer.Dto
{
	public class OrderAddDto
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
        public DateTime OrderDateTime { get; set; }
    }
}
