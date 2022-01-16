using System;
using System.Collections.Generic;
using localiza.frotas.Domain;

namespace localiza.frotas.Domain
{
    public interface IVeiculoRepository
    {
        void Add(Veiculo veiculo);
        void Delete(Veiculo veiculo);
        void Update(Veiculo veiculo);
        Veiculo GetById(Guid Id);
        IEnumerable<Veiculo> GetAll();
    }
}