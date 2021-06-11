using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventoryContext())
            {
                return db.InputOutputs.ToList();
            }
        }

        public static void CreateInputOutput(InputOutputEntity obj)
        {
            using (var db = new InventoryContext())
            {
                db.InputOutputs.Add(obj);
                db.SaveChanges();
            }
        }
        public static void UpdateInputOutput(InputOutputEntity obj)
        {
            using (var db = new InventoryContext())
            {
                db.InputOutputs.Update(obj);
                db.SaveChanges();
            }
        }
    }
}
