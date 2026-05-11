namespace Pablo_movie_mvc.Models
{
    public class Plataforma
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string Url { get; set; }
        public string LogoUrl { get; set; }
        public List<Pelicula>? PeliculasPlataforma { get; set; }
    }
}
