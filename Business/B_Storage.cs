using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventoryContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity obj)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Add(obj);
                db.SaveChanges();
            }
        }
        public static void UpdateStorage(StorageEntity obj)
        {
            using (var db = new InventoryContext())
            {
                db.Storages.Update(obj);
                db.SaveChanges();
            }
        }
    }
}
