using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pablo_movie_mvc.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Titulo { get; set; }
        [DataType (DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }
        [Required]
        [StringLength (1000)]
        public string Sinopsis { get; set; }
        [Required]
        [Range(1, 200)]
        public int MinutosDuracion { get; set; }
        [Url]
        [Required]
        public string PosterUrlPortada { get; set; }
        public Genero? Genero { get; set; }
        public int GeneroId { get; set; }
        public Plataforma? Plataforma { get; set; }
        public int PlataformaId { get; set; }

        [NotMapped]
        public int PromedioRating { get; set; }
        public List<Review>? ListaReviews { get; set; }
        public List<Favorito>? UsuariosFavorito { get; set; }
    }
}
