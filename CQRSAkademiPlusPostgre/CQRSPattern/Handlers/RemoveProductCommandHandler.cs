using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveProductCommand removeProductCommand)
        {
           var values= _context.Products.Find(removeProductCommand.Id);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
        
    }
}
