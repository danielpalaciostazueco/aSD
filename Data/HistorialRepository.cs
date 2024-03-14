using Microsoft.EntityFrameworkCore;
using UrbanTheater.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using UrbanTheater.Data;

namespace UrbanTheater.Data
{
    public class HistorialRepository : IHistorialRepository
    {
        private readonly UrbanTheaterAppContext _context;
        private readonly ILogger<HistorialRepository> _logger;


        public HistorialRepository(UrbanTheaterAppContext context, ILogger<HistorialRepository> logger)
        {
            _context = context;
            _logger = logger;

        }
        public List<Historial> Get(string name)
        {
            try
            {
                return _context.Historial.ToList().Where(x => x.nombreUsuario == name).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error obteniendo el historial por defecto.");
                throw;
            }
        }

        public void Add(string nombreUsuario, string nombreObra, System.DateTime fecha, string sesion, int asiento)
        {
            try
            {
                var historial = new Historial
                {
                    nombreUsuario = nombreUsuario,
                    nombreObra = nombreObra,
                    fecha = fecha,
                    sesion = sesion,
                    asiento = asiento
                };
                
                _context.Historial.Add(historial);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error añadiendo el historial.");
                throw;
            }
        }
    }
}
