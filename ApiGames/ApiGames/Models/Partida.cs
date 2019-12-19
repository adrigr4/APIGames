using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGames.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public string Dificultad { get; set; }
        public string Juego { get; set; }
        public Jugador Creador { get; set; }
        public ICollection<Jugador> Jugadores { get; set; }
    }
}
