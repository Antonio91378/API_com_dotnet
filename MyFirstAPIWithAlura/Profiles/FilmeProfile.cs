using AutoMapper;
using MyFirstAPIWithAlura.Controllers;
using MyFirstAPIWithAlura.Data.Dtos;

namespace MyFirstAPIWithAlura.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}