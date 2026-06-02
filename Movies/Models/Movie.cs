using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Titulo")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de liberacion")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genero")]
        public string? Genre { get; set; }

        [Display(Name = "Precio")]
        public decimal Price { get; set; }
    }
}
