using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BrandModel:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
    }
}
