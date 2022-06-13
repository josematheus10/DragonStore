using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DragonStore.Catalogo.Application.ViewModels;
using DragonStore.Catalogo.Domain;

namespace DragonStore.Catalogo.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}
