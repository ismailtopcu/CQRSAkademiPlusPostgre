using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;
using System.Security.Policy;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductName= command.ProductName,
                ProductBrand= command.ProductBrand,
                ProductCategory= command.ProductCategory,
                ProductPrice= command.ProductPrice,
                ProductStock= command.ProductStock,
                ProductStockType= command.ProductStockType,
                Tax = command.Tax,
                LastUseDate= command.LastUseDate,
                Barcode= command.Barcode,
                Publisher= command.Publisher,
                ShelfNumber= command.ShelfNumber
            });
            _context.SaveChanges();
        }
    }
}
