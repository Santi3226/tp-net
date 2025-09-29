using Domain.Model;
using Data;
using DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Application.Services
{
    public class TipoAnalisisService
    {
        public TipoAnalisisDTO Add(TipoAnalisisDTO dto)
        {
            var tipoAnalisisRepository = new TipoAnalisisRepository();
            TipoAnalisis ta = new TipoAnalisis(0, dto.Nombre, dto.Importe);
            tipoAnalisisRepository.Add(ta);

            dto.Id = ta.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var tipoAnalisisRepository = new TipoAnalisisRepository();
            return tipoAnalisisRepository.Delete(id);
        }

        public TipoAnalisisDTO Get(int id)
        {
            var tipoAnalisisRepository = new TipoAnalisisRepository();

            TipoAnalisis? ta = tipoAnalisisRepository.Get(id);
            if (ta == null)
                return null;

            return new TipoAnalisisDTO
            {
                Id = ta.Id,
                Nombre = ta.Nombre,
                Importe = ta.Importe,
            };
        }

        public IEnumerable<TipoAnalisisDTO> GetAll()
        {
            var tipoAnalisisRepository = new TipoAnalisisRepository();
            return tipoAnalisisRepository.GetAll().Select(ta => new TipoAnalisisDTO
            {
                Id = ta.Id,
                Nombre = ta.Nombre,
                Importe = ta.Importe,          
            }).ToList();
        }

        public bool Update(TipoAnalisisDTO dto)
        {
            var tipoAnalisisRepository = new TipoAnalisisRepository();
            TipoAnalisis tipoAnalisis = new TipoAnalisis(dto.Id, dto.Nombre, dto.Importe);
            return tipoAnalisisRepository.Update(tipoAnalisis);
        }
    }
}
