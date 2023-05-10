using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.CQRSPattern.Handlers;
using CQRSAkademiPlusPostgre.CQRSPattern.Querries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using Microsoft.AspNetCore.Mvc;

namespace CQRSAkademiPlusPostgre.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUptadeByIDQueryHandler _getProductUptadeByIDQueryHandler;

        public ProductController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUptadeByIDQueryHandler getProductUptadeByIDQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUptadeByIDQueryHandler = getProductUptadeByIDQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand createProductCommand)
        {
            _createProductCommandHandler.Handle(createProductCommand);
            return RedirectToAction("Index");
        }
        public IActionResult DetailProduct(int id)
        {
            var values = _getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUptadeByIDQueryHandler.Handle(new GetProductUpdateByIDQuery(id));
            return View(values);
        }
    }
}
