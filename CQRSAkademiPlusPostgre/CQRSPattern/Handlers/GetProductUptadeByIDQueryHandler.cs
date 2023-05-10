using CQRSAkademiPlusPostgre.CQRSPattern.Querries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductUptadeByIDQueryHandler
    {
        private readonly Context _context;
        public GetProductUptadeByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductBrand = values.ProductBrand,
                ProductCategory = values.ProductCategory,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                ProductStockType = values.ProductStockType,
                Publisher = values.Publisher,
                Tax = values.Tax,
                Barcode = values.Barcode,
                LastUseDate = values.LastUseDate,
                ShelfNumber = values.ShelfNumber
            };
        }
    }
}
