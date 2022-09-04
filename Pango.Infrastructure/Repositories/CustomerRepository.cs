using Microsoft.EntityFrameworkCore;
using Pango.Domain.Interfaces;
using Pango.Domain.Entities;

namespace Pango.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly PangoContext _dbContext;

    public CustomerRepository(PangoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        return await _dbContext.Customer
            .ToArrayAsync();
    }

    public async Task<Customer> CreateAsync(Customer customer)
    {
        _dbContext.Customer.Add(customer);
        await _dbContext.SaveChangesAsync();
        return customer;
    }

    public async Task<Customer> UpdateAsync(Customer customer)
    {
        _dbContext.Customer.Update(customer);
        await _dbContext.SaveChangesAsync();
        return customer;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var customer = await _dbContext.Customer.FirstAsync(x => x.Id == id);
        if (customer == null)
            return false;

        _dbContext.Customer.Remove(customer);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}
