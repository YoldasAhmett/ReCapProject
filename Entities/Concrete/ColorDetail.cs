using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ColorDetail:IEntity
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public string Description { get; set; }
    }
}
