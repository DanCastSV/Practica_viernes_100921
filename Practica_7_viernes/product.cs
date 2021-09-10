using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7_viernes
{
    class product
    {
        public int cdProduct { get; set; }

        public string productName { get; set; }

        public string productDescription { get; set; }
        
        public string productCategory { get; set; }

        public double buyPrice { get; set; }


        public static List<product> GetProducts()
        {
            List<product> products = new List<product>
          {
            new product{ cdProduct= 12001, productName="Coca Cola", productDescription= "Bebida carbonatada distribuida por ILC",productCategory="Bebida" ,buyPrice=0.55d},
            new product{ cdProduct= 12002, productName="Jalapeños", productDescription= "fritura de maiz sabor a jalapeño distribuido por Diana",productCategory="Snacks" , buyPrice=0.15d},
            new product{ cdProduct= 12003, productName="Gatorade", productDescription= "Bebida energisante distribuida por ILC",productCategory="Bebida" , buyPrice=0.85d},
            new product{ cdProduct= 12004, productName="Sponchs", productDescription= "Galleta de fresa o chocolate distribuida por Bimbo",productCategory="Snacks" , buyPrice=0.75d},
            new product{ cdProduct= 12005, productName="Fanta", productDescription= "Bebida carbonatada distribuida por ILC",productCategory="Bebida" ,buyPrice=0.55d},

          };
          return products;
        }
    }
}
