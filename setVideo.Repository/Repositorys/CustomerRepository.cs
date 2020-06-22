using System.Linq;
using setVideo.Model;

namespace setVideo.Repository
{
    public class CustomerRepository : BaseRepository<setVideoContext, Customer>, ICustomerRepository
    {
        public CustomerRepository(setVideoContext contexto)
        {
            DataContext = contexto;
            DbSet = DataContext.Set<Customer>();
        }

        public Customer getByCpf(string cpf)
        {
            return DataContext.Customers.FirstOrDefault(x => x.cpf == cpf);
        }
    }

    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Customer getByCpf(string cpf);
    }
}
