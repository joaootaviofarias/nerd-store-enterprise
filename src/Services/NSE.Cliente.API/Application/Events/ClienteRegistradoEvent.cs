using System;
using NSE.Core.Messages;

namespace NSE.Cliente.API.Application.Events
{
    public class ClienteRegistradoEvent : Event
    {
        public ClienteRegistradoEvent(Guid id, string nome, string email, string cpf)
        {
            Id = id;
            AggregateId = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
        
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
    }
}