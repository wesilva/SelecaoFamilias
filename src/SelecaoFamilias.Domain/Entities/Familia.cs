using Flunt.Validations;
using SelecaoFamilias.Domain.Core.Entities;
using SelecaoFamilias.Domain.Enums;
using SelecaoFamilias.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SelecaoFamilias.Domain.Entities
{
    public class Familia : Entity
    {
        private IList<Pessoa> _pessoas;
        public Familia(Status status)
        {
            Id = new EntityId(Guid.NewGuid());
            Status = status;
            _pessoas = new List<Pessoa>();
        }

        public EntityId Id { get; private set; }
        public Status Status { get; private set; }
        public IReadOnlyCollection<Pessoa> Pessoas { get { return _pessoas.ToList(); } }

        private Familia() {}

        public override bool EhValido()
        {
            Validar();
            return this.Valid;
        }

        public void AdicionarPessoa(Nome nome, ETipoType tipo, Idade idade, Renda renda)
        {
            var pessoa = new Pessoa(Id, nome, tipo, idade, renda);
            if (pessoa.Invalid) 
                AddNotifications(pessoa);
            _pessoas.Add(pessoa);
        }

        public decimal ObterRendaTotal()
        {
           return _pessoas.Select(x => x.Renda.Valor).Sum();
        }

        public int ObterIdadePretendente()
        {
            return _pessoas.FirstOrDefault(x => x.EhPretendente()).ObterIdade();
        }

        public int ObterQuantidadeDeDependentesMenorDe18Anos()
        {
            return _pessoas.Count(x => x.EhDependente() && x.EhMenorDe18Anos());
        }

        private void Validar()
        {
            ValidarSePossuiConjugue();
            ValidarSePossuiPretendente();
        }

        private void ValidarSePossuiPretendente()
        {
            int quantidadePretendente = _pessoas.Count(p => p.EhPretendente());
            AddNotifications(new Contract()
                .Requires()
                .AreEquals(quantidadePretendente, 1, "Familia.pessoa", "Deve ter somente 1 pretendente")                
            );
        }
        private void ValidarSePossuiConjugue()
        {
            int quantidadeConjugue = _pessoas.Count(p => p.EhConjugue());
            AddNotifications(new Contract()
                .Requires()
                .AreEquals(quantidadeConjugue, 1, "Familia.pessoa", "Deve ter somente 1 conjugue")
            );
        }
    }
}
