﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int stock { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
