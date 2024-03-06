﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public Slot Slot { get; set; }
        public decimal TotalPrice { get; set; }
        public User User { get; set; }
        public SportGround SportGround { get; set; }
        public Recipt Recipt { get; set; }
    }
}
