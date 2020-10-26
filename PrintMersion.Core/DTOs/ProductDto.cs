﻿using PrintMersion.Core.Interfaces;
namespace PrintMersion.Core.DTOs
{
    public class ProductDto : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
