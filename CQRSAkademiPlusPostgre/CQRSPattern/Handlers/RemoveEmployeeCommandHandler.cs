using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class RemoveEmployeeCommandHandler
    {
        private readonly Context _context;

        public RemoveEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveEmployeeCommand removeEmployeeCommand)
        {
            var values = _context.Employees.Find(removeEmployeeCommand.Id);
            _context.Employees.Remove(values);
            _context.SaveChanges();
        }
    }
}
