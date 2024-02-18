using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "tytul jest wymagany")]
        [StringLength(100, ErrorMessage = "tytul nie może być dluzszy niz 100znakow")]
        public string Title { get; set; }
        [Required(ErrorMessage = "autor jest wymagany")]
        public string Author { get; set; }
        [Required(ErrorMessage = "gatunek jest wymagany")]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "data wydania jest wymagana")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Liczba sztuk jest wymagana")]
        [Range(1, 20, ErrorMessage = "Liczba sztuk musi byc w przedziale od 1 do 20")]
        public byte NumberInStock { get; set; }
    }
}
