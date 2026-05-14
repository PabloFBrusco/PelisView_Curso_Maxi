using System.ComponentModel.DataAnnotations;

namespace Pablo_movie_mvc.Models
{
    public class Review
    {
        public int Id { get; set; }
        public Usuario? Usuario { get; set; }
        public Pelicula? Pelicula { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }
        [Required]
        [StringLength(500)]
        public string Comentario { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaReview { get; set; }
        public int PeliculaId { get; set; }
        public string UsuarioId { get; set; }
        //row version for currency control




    }
}
