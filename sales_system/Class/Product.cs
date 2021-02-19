using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system.Class
{
    class Product
    {
        public string NameProduct;
        public int Price;

        public static implicit operator string(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
