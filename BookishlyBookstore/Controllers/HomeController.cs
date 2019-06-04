using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookishlyBookstore.Models;
using BookishlyBookstore.ViewModels;


namespace BookishlyBookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {


            var books = _bookRepository.GetAllBooks().OrderBy(b => b.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to the Bookishly Bookstore!",
                Books = books.ToList()
            };

            return View(homeViewModel);
        }


        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
                return NotFound();

            return View(book);
        }
    }
}
