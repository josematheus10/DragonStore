﻿using System.Collections.Generic;
using DragonStore.Core.DomainObjects;

namespace DragonStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        // EF Relation
        public ICollection<Produto> Produtos { get; set; }

        protected Categoria() { }
        
        public Categoria(string nome, int codigo, Guid id = default(Guid))
        {
            Nome = nome;
            Codigo = codigo;
            Id = id;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome da categoria não pode estar vazio");
            Validacoes.ValidarSeIgual(Codigo, 0, "O campo Codigo não pode ser 0");
        }
    }
}