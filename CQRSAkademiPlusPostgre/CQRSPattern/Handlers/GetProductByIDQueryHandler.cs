using CQRSAkademiPlusPostgre.CQRSPattern.Querries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductByIDQueryResult
            {
                ProductName=values.ProductName,
                ProductBrand=values.ProductBrand,
                ProductCategory=values.ProductCategory,
                ProductID=values.ProductID,
                ProductPrice=values.ProductPrice,
                ProductStock=values.ProductStock             
            };
        }
    }
}
