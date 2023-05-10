using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class CreateEmployeeCommandHandler
    {
        private readonly Context _context;

        public CreateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateEmployeeCommand command)
        {
            _context.Employees.Add(new Employee
            {
                EmployeeName= command.EmployeeName,
                EmployeeAge= command.EmployeeAge,
                EmployeeCity= command.EmployeeCity,
                EmployeeSalary= command.EmployeeSalary,
                EmployeeSurname= command.EmployeeSurname,
                EmployeeTitle= command.EmployeeTitle
            });
            _context.SaveChanges();
        }
    }
}
