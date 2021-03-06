﻿using Dapper.Contrib.Extensions;
using SGA.Domain.Entities.Core;
using SGA.Domain.Entities.ValueObjects;
using System;

namespace SGA.Domain.Entities.Models
{
    [Table("responsavel")]
    public class Responsible : Entity
    {
        public Responsible(Guid id, string name, string cpf, string email)
        {
            Id = id;
            Name = name;
            Cpf = new Cpf(cpf);
            Email = new Email(email);
        }

        protected Responsible() { }

        public string Name { get; protected set; }

        public Cpf Cpf { get; protected set; }

        public Email Email { get; protected set; }

        public void SetEmail(Email email)
        {
            //Todo: Add Email  Validation here

            Email = email;
        }

        public void SetCpf(Cpf cpf)
        {
            //Todo: Add Cpf Validation here
            Cpf = cpf;
        }
    }
}
