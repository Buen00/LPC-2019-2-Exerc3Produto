using crudproduto.Models;
using Microsoft.AspNetCore.Mvc;

namespace crudproduto.Controllers
{
    public class ProdutoController : Controller
    {
        CarroRepository _repository = 
        new CarroRepository();

        public IActionResult Index()
        {
            var carros = _repository.GetAll();          

            return View(carros);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Carro carro)
        {
            _repository.Create(carro);

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

       [HttpGet]
        public IActionResult Edit(int id)
        {
            var car = _repository.GetByid(id);
            return View(car);
        }

        [HttpPost]
        public IActionResult Edit(Carro carroAlterado)
        {
            _repository.Update(carroAlterado);

            return RedirectToAction("index");
        }
    
    }
}