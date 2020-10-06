using Chacrutaria.Models;

namespace Chacrutaria.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriaPedido(int clienteId, ref Pedido pedidoRetorno);
    }
}
