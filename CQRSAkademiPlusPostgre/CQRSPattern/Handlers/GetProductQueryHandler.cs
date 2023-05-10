using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID= x.ProductID,
                ProductName= x.ProductName,
                ProductBrand= x.ProductBrand,
                ProductCategory= x.ProductCategory,
                ProductPrice= x.ProductPrice,
                ProductStock= x.ProductStock,
                ProductStockType= x.ProductStockType,
                Publisher=x.Publisher,
                Barcode= x.Barcode,
                LastUseDate= x.LastUseDate,
                ShelfNumber = x.ShelfNumber,
                Tax= x.Tax
                  
            }).ToList();
            return values;
        }
    }
}
