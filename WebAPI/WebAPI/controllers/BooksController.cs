using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.controllers;

// A controller directs and manages flow of data between entities

// This is the route that this controller manages
// We could type "/books/" but this also works - taking the name of the controller - BooksController (drops the controller part to just use 'books')
[Route("/[controller]")]
[ApiController]
public class BooksController: ControllerBase
{
    // Name variables lowercase
    // Name classes Uppercase
    // the <Book> is the type - you don't have to just use string, int, float etc
    
    //IList is a thing in dotnet - it's a list, basically an array
    private readonly IList<Book> _books = new List<Book>
    {
        // new item in List (array) using the class Book
        new Book
        {
            Title = "Neils book",
            Author = "Neil",
            Id = 1,
            ReleaseDate = DateTime.Now,
        },
        new Book
        {
            Title = "Neils book two",
            Author = "Neil again",
            Id = 2,
            ReleaseDate = DateTime.Now,
        },
        
    };

    // A HttpGet - I assume you can do lots of different requests
    [HttpGet]
    public ActionResult<Book> GetBooks([FromQuery]string? author)
    {
        return !string.IsNullOrWhiteSpace(author) ? Ok(_books.FirstOrDefault(book => book.Author == author )) : Ok(_books);
    }
    
    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(int id)
    {
        return Ok(_books.FirstOrDefault(book => book.Id == id));
    }
}