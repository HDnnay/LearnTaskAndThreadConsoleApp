using FactoryPatternApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternApp.Factoris
{
    public class ConcreateFactory : AbstractFactory
    {
        public override IProduct CreateProduct()
        {
            throw new NotImplementedException();
        }

        public override IProductOne CreateProductOne()
        {
            throw new NotImplementedException();
        }
    }
}
