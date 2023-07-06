using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreMagementApi.Data;

namespace StoreMagementApi.Services.StoreServices
{
    public class StoreProduct : IStoreAdmin
    {
        public StoreContxt _storeContxt;

        public StoreProduct(StoreContxt storeContxt) 
        {
            _storeContxt = storeContxt;        
        }
        public async Task<List<StoreManagement>> GetProductDetails()
        {
            var AllProd = await _storeContxt.storeManagements.ToListAsync();
            return AllProd;
        }
        /*public async Task<List<StoreManagement?>> GetStudIDPost()
        {
            var Prod = await _storeContxt.storeManagements.FirstOrDefaultAsync();
            return ;
            var Prod = new StoreManagement
            {
                Product_id = 1,
                Product_name = "Milk",
                Quantity_available = 120,
                Cost = 1200

            };
            //IStoreAdmin.Add(stud);
            
        }*/
    }
}
