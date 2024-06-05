using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

// Models represent the data and business logic of our application
// This is the model / class Book

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Id { get; set; }
}