namespace StoreMagementApi.Services.StoreServices
{
    public interface IStoreAdmin
    {
        Task<List<StoreManagement>> GetProductDetails();
        //Task<List<StoreManagement?>> InsertProductDetails();
    }
}
