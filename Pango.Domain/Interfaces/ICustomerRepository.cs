using Pango.Domain.Entities;

namespace Pango.Domain.Interfaces;

public interface ICustomerRepository
{
    public Task<IEnumerable<Customer>> GetAllCustomersAsync();

    public Task<Customer> CreateAsync(Customer customer);

    public Task<Customer> UpdateAsync(Customer customer);

    public Task<bool> DeleteAsync(Guid id);
}
