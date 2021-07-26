using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // public yaptığımızda bu  class'a diğer katmanlarda ulaşabilsin diye ekliyoruz
   public class Product: IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }

    }
}
