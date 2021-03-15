using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BrandDetailDto : IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
