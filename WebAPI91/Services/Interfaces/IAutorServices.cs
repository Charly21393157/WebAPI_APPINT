using Domain.DTO;
using Domain.Entities;

namespace WebAPI_APPINT.Services.Interfaces
{
    public interface IAutorServices
    {
        public Task<Response<List<Autor>>> GetAutores();
        public Task<Response<Autor>> Crear(AutorResponsive i);
    }
}
