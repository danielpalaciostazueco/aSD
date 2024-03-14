using System.Collections.Generic;
using UrbanTheater.Models;

namespace UrbanTheater.Data
{
    public interface IHistorialRepository
    {
        List<Historial> Get(string name);
        void Add(string nombreUsuario, string nombreObra, System.DateTime fecha, string sesion, int asiento);
    }
}
