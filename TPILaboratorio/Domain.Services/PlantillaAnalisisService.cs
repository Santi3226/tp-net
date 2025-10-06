using Domain.Model;
using Data;
using DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Application.Services
{
    public class PlantillaAnalisisService
    {
        public PlantillaAnalisisDTO Add(PlantillaAnalisisDTO dto)
        {
            var plantillaAnalisisRepository = new PlantillaAnalisisRepository();
            PlantillaAnalisis ta = new PlantillaAnalisis(0, dto.HsAyuno, dto.Preparacion, dto.DiasPrevistos);
            plantillaAnalisisRepository.Add(ta);

            dto.Id = ta.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var plantillaAnalisisRepository = new PlantillaAnalisisRepository(); 
            return plantillaAnalisisRepository.Delete(id);
        }

        public PlantillaAnalisisDTO Get(int id)
        {
            var plantillaAnalisisRepository = new PlantillaAnalisisRepository();
            PlantillaAnalisis? ta = plantillaAnalisisRepository.Get(id);
            if (ta == null)
                return null;

            return new PlantillaAnalisisDTO
            {
                Id = ta.Id,
                HsAyuno = ta.HsAyuno,
                Preparacion = ta.Preparacion,
                DiasPrevistos = ta.DiasPrevistos,
            };
        }

        public IEnumerable<PlantillaAnalisisDTO> GetAll()
        {
            var plantillaAnalisisRepository = new PlantillaAnalisisRepository(); 
            return plantillaAnalisisRepository.GetAll().Select(ta => new PlantillaAnalisisDTO
            {
                Id = ta.Id,
                HsAyuno = ta.HsAyuno,
                Preparacion = ta.Preparacion,
                DiasPrevistos = ta.DiasPrevistos
            }).ToList();
        }

        public bool Update(PlantillaAnalisisDTO dto)
        {
            var plantillaAnalisisRepository = new PlantillaAnalisisRepository();
            PlantillaAnalisis plantillaAnalisis = new PlantillaAnalisis(dto.Id, dto.HsAyuno, dto.Preparacion, dto.DiasPrevistos);
            return plantillaAnalisisRepository.Update(plantillaAnalisis);
        }
    }
}
