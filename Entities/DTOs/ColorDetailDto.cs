using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ColorDetailDto : IDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
