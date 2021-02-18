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
        private readonly BookService bookService;
        public SerchController(BookService bookService) 
        {
            this.bookService = bookService;
        }
        public IActionResult Index(string query)
        {
            var books = bookService.GetAllByQuery(query);
            return View("Index",books);
        }
    }
}
