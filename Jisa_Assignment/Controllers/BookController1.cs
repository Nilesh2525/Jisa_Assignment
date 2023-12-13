using Jisa_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace Jisa_Assignment.Controllers
{
    public class BookController1 : Controller
    {

        private readonly BookDal dal;
         
        public BookController1()
        {
            dal = new BookDal();  
        }
        public ActionResult Index()
        {
            var model = dal.GetAllBook();
            return View(model);
        }

        // GET: BookController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            var result = dal.AddBook(book);
            return RedirectToAction("Index");
        }

        // GET: BookController1/Edit/5
        public ActionResult Edit(int id)
        {
            Book book = dal.GetAllBook().Find(b => b.Id == id);
            if (book== null)
            {
                return NotFound();
            }
            
            return View(book);
        }

        // POST: BookController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {

            dal.UpdateBook(book);
            return RedirectToAction("Index");
            
        }

        // GET: BookController1/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = dal.GetAllBook().Find(b => b.Id == id);
            if(book== null)
            {
                return NotFound();
            }
            return View();
        }

        // POST: BookController1/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete(Book book)
        {
            var result = dal.DeleteBook(book);
            return RedirectToAction("Index");
        }
    }
}
