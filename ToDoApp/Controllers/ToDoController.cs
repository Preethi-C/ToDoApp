using Microsoft.AspNetCore.Mvc;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        public ToDoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
        List<ToDo> objToDoList = _db.ToDos.ToList();
            return View(objToDoList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ToDo obj) 
        {
            _db.ToDos.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? Id)
        {   
            if(Id==0 || Id==null)
            {
                return NotFound();
            }
            ToDo? todoobj = _db.ToDos.FirstOrDefault(x => x.Id==Id);
            if(todoobj==null)
            {
                return NotFound();
            }
            return View(todoobj);
        }
        [HttpPost,ActionName("Edit")]
        public IActionResult EditPOST(ToDo obj)
        {
            if (ModelState.IsValid)
            {
                _db.ToDos.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        

    }
}
