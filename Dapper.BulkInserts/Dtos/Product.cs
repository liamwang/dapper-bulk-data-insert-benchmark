﻿using System;

namespace Dapper.BulkInserts.Dtos
{
    public class Product
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Location { get; set; }

        public string Category { get; set; }

        public string Manufacturer { get; set; }
        
        public string Condition { get; set; }
    }
}
