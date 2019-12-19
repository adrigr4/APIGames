using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGames.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Alias { get; set; }
        public ICollection<Partida> PartidasCreadas { get; set; }
        public ICollection<Partida> PartidasActuales { get; set; }
    }
}
