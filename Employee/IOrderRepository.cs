﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public interface IOrderRepository
    {
        Order GetbyId(int Id);
    }

    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
