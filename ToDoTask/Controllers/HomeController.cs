using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoTask.Context.Repository;
using ToDoTask.Entities;


namespace ToDoTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ToDoTask.Context.Context db = new ToDoTask.Context.Context();
            UnitOfWork uow = new UnitOfWork(db);
            Repository<Todo> rpRepository = new Repository<Todo>(uow);
            Todo todo = new Todo();
            todo.Day = DateTime.Now;
            todo.Description = "fdsvsdfv333";
            todo.Task = "fdvsdfvdsf";
            todo.User = new User();
            rpRepository.Add(todo);
            uow.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}