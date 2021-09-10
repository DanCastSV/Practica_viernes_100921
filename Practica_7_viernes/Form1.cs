using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7_viernes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngetnames_Click(object sender, EventArgs e)
        {
            SelectProductsName();
        }

        private void SelectProductsName()
        {
            
            List<string> productList = (
                from product in product.GetProducts()
                select product.productName
                ).ToList();

           
            foreach (var product in productList)
                lstProductsName.Items.Add(product);

        }

        private void btngetdatta_Click(object sender, EventArgs e)
        {
            dgAllProducts.Columns.Add("codProduct", "Codigo de producto");
            dgAllProducts.Columns.Add("name", "Nombre del producto");
            dgAllProducts.Columns.Add("descripcion", "Descripción del producto");
            dgAllProducts.Columns.Add("category", "Categoria del producto");
            dgAllProducts.Columns.Add("price", "Precio del producto");

            foreach (var product in selectAllProducts())
            {
                dgAllProducts.Rows.Add(product.cdProduct, product.productName, product.productDescription,
                    product.productCategory ,product.buyPrice);
            }

        }

        private List<product> selectAllProducts()
        {
            List<product> getAllProducts = (
                from product in product.GetProducts()
                select new product()
                {
                    cdProduct = product.cdProduct,
                    productName = product.productName,
                    productDescription = product.productDescription,
                    productCategory = product.productCategory,
                    buyPrice = product.buyPrice
                }
                ).ToList();


            return getAllProducts;
        }


    }
}
