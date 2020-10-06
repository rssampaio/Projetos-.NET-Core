using Chacrutaria.Context;
using Chacrutaria.Models;
using Chacrutaria.Repositories.Interfaces;

namespace Chacrutaria.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _appDbContext;

        public ClienteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int CadastraCliente(Cliente cliente)
        {
            _appDbContext.Clientes.Add(cliente);

            _appDbContext.SaveChanges();

            return cliente.ClienteId;
        }
    }
}
