﻿using System;

namespace CP2.Domain.Interfaces.Dtos
{
    public interface IFornecedorDto
    {
        int Id { get; set; }
        string Nome { get; set; }
        string CNPJ { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }
        string Email { get; set; }
        DateTime CriadoEm { get; set; }

        void Validate();
    }
}