using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternApp.Products;

namespace FactoryPatternApp.Factoris
{
    public abstract class AbstractFactory
    {
        public abstract IProduct CreateProduct();
        public abstract IProductOne CreateProductOne();
    }
}
