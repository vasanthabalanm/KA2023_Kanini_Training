using ApiStores.Models;

namespace ApiStores.Repository.Bill
{
    public interface ICustProductService
    {
        Task<List<CustomerProd>?> GetCustomerProds();

        Task<CustomerProd>? GetCustomerProd(int id);

        Task<List<CustomerProd>?> PutCustomerProd(int id, CustomerProd cust);

        Task<List<CustomerProd>> PostCustomerProd(CustomerProd cust);

        Task<List<CustomerProd>> DeleteCustomerProd(int id);

    }
}
