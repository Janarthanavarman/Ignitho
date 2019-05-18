using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
namespace ECommerce.Repository
{
    public class purchaseRepository : IpurchaseRepository
    {
        // "DefaultConnection": "Server=tcp:xxUAT.domain.com,64609;Initial Catalog=IdentityDB;MultipleActiveResultSets=true;User ID=xx;Password=xx"
        eCommIMContext context;
        public purchaseRepository(eCommIMContext context)
        {
            this.context = context;
        }

        public IEnumerable<purchaseModel> getAllPurchase()
        {
            return context.purchaseModel.Where(x => x.status == 'A').ToList();
        }

        public purchaseModel getPurchase(int id)
        {
            return context.purchaseModel.Where(x => x.id == id && x.status == 'A').FirstOrDefault();
        }

        public bool addPurches(purchaseModel purchase)
        {
            try
            {
                purchase.createon = System.DateTime.Now;
                purchase.createby = 1;
                context.Add(purchase);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}