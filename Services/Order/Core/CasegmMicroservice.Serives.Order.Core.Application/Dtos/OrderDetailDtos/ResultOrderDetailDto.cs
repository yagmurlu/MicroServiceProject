using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasegmMicroservice.Serives.Order.Core.Application.Dtos.OrderDetailDtos
{
	public class ResultOrderDetailDto
	{
		public int OrderDetailID { get; set; }
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductAmount { get; set; }
		public int OrderingID { get; set; }
	}
}
