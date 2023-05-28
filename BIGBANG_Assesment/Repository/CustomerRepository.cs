using BIGBANG_Assesment.Models;
using BIGBANG_Assesment.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BIGBANG_Assesment.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly HotelContext _dbContext;

        public CustomerRepository(HotelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.Include(x => x.Reservations).ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.Find(id);
        }

        public void AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }
    }
}
