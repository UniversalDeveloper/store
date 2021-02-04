using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using store;

namespace Store.Web.Controllers
{
    public class SerchController : Controller
    {
        private readonly IBookRepository bookRepository;
        public SerchController(IBookRepository bookRepository) 
        {
            this.bookRepository = bookRepository;
        }
        public IActionResult Index(string query)
        {
            var books = bookRepository.GetAllByTitleOrAuthor(query);
            return View(books);
        }
    }
}
