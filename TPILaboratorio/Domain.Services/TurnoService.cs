using Domain.Model;
using Data;
using DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace Application.Services
{
    public class TurnoService
    {
        public TurnoDTO Add(TurnoDTO dto)
        {
            var turnoRepository = new TurnoRepository();
            var pacienteRepository = new PacienteRepository();
            var tipoAnalisisRepository = new TipoAnalisisRepository();
            var centroAtencionRepository = new CentroRepository();
            Paciente? p = pacienteRepository.Get(dto.IdPaciente);
            TipoAnalisis? ta = tipoAnalisisRepository.Get(dto.IdTipoAnalisis);
            CentroAtencion? ca = centroAtencionRepository.Get(dto.IdCentroAtencion);

            Turno t = new Turno(0, dto.RecibeMail, dto.Estado, dto.Receta, dto.Observaciones,
            dto.FechaHoraReserva, dto.FechaHoraExtraccion, p, ta,ca);
            turnoRepository.Add(t);

            dto.Id = t.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var turnoRepository = new TurnoRepository();
            return turnoRepository.Delete(id);
        }

        public TurnoDTO Get(int id)
        {
            var turnoRepository = new TurnoRepository();

            Turno? t = turnoRepository.Get(id);
            if (t == null)
                return null;

            return new TurnoDTO
            {
                Id = t.Id,
                Estado = t.Estado,
                RecibeMail = t.RecibeMail,
                Receta = t.Receta,
                Observaciones = t.Observaciones,
                FechaHoraReserva = t.FechaHoraReserva,
                FechaHoraExtraccion = t.FechaHoraExtraccion,
                IdPaciente = t.Paciente?.Id ?? 0,
                IdTipoAnalisis = t.TipoAnalisis?.Id ?? 0,
                IdCentroAtencion = t.CentroAtencion?.Id ?? 0
            };
        }

        public IEnumerable<TurnoDTO> GetAll()
        {
            var turnoRepository = new TurnoRepository();
            return turnoRepository.GetAll().Select(t => new TurnoDTO
            {
                Id = t.Id,
                Estado = t.Estado,
                RecibeMail = t.RecibeMail,
                Receta = t.Receta,
                Observaciones = t.Observaciones,
                FechaHoraReserva = t.FechaHoraReserva,
                FechaHoraExtraccion = t.FechaHoraExtraccion,
                IdPaciente = t.Paciente?.Id ?? 0,
                IdTipoAnalisis = t.TipoAnalisis?.Id ?? 0,
                IdCentroAtencion = t.CentroAtencion?.Id ?? 0
            }).ToList();
        }

        public IEnumerable<TurnoDTO> GetByPacienteId(int pacienteId)
        {
            var turnoRepository = new TurnoRepository();
            return turnoRepository.GetByPacienteId(pacienteId).Select(t => new TurnoDTO
            {
                Id = t.Id,
                Estado = t.Estado,
                RecibeMail = t.RecibeMail,
                Receta = t.Receta,
                Observaciones = t.Observaciones,
                FechaHoraReserva = t.FechaHoraReserva,
                FechaHoraExtraccion = t.FechaHoraExtraccion,
                IdPaciente = t.Paciente?.Id ?? 0,
                IdTipoAnalisis = t.TipoAnalisis?.Id ?? 0,
                IdCentroAtencion = t.CentroAtencion?.Id ?? 0
            }).ToList();
        }

        public bool Update(TurnoDTO dto)
        {
            var turnoRepository = new TurnoRepository();
            var pacienteRepository = new PacienteRepository();
            var tipoAnalisisRepository = new TipoAnalisisRepository();
            var centroAtencionRepository = new CentroRepository();
            Paciente? p = pacienteRepository.Get(dto.IdPaciente);
            TipoAnalisis? ta = tipoAnalisisRepository.Get(dto.IdTipoAnalisis);
            CentroAtencion? ca = centroAtencionRepository.Get(dto.IdCentroAtencion);
            //Aca encuentra bien el paciente
            Turno turno = new Turno(dto.Id, dto.RecibeMail, dto.Estado, dto.Receta, dto.Observaciones,
            dto.FechaHoraReserva, dto.FechaHoraExtraccion, p, ta,ca);
            return turnoRepository.Update(turno);
        }
        
        public IEnumerable<TurnoDTO> GetByADO()
        {
            var turnoRepository = new TurnoRepository();

            var turnos = turnoRepository.GetByADO();

            // Mapear Domain Model a DTO
            return turnos.Select(t => new TurnoDTO
            {
				Id = t.Id,
				Estado = t.Estado,
				RecibeMail = t.RecibeMail,
				Receta = t.Receta,
				Observaciones = t.Observaciones,
				FechaHoraReserva = t.FechaHoraReserva,
				FechaHoraExtraccion = t.FechaHoraExtraccion,
				IdPaciente = (int)(t.Paciente?.Id),
				IdTipoAnalisis = (int)(t.TipoAnalisis?.Id),
				IdCentroAtencion = (int)(t.CentroAtencion?.Id)
			});
        }
    }
}