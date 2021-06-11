using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public static void CreateProduct(ProductEntity obj)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Add(obj);
                db.SaveChanges();
            }
        }
        public static void UpdateProduct(ProductEntity obj)
        {
            using (var db = new InventoryContext())
            {
                db.Products.Update(obj);
                db.SaveChanges();
            }
        }
    }
}
