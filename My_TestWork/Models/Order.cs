using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_TestWork.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public DateTime? DateOfCreate { get; set; }
        public DateTime? DateOfShipment { get; set; }
        public string Manager { get; set; }

    }
}