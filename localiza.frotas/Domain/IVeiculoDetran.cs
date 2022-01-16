using System;
using System.Threading.Tasks;

namespace localiza.frotas.Domain
{
    public interface IVeiculoDetran
    {
       public Task AgendarVistoriaDetran(Guid veiculoId);
    }
}