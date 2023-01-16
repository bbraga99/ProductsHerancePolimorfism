using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercicioProposto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name,double price,DateTime manufactureDate) : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + "(used)" + " $" + Price + "(Manufacture date: )" + ManufactureDate.ToString("dd/MM/yyyy");
        }

    }
}
