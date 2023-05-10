using CQRSAkademiPlusPostgre.CQRSPattern.Querries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.DAL;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetEmployeeUpdateByIDQueryHandler
    {
        private readonly Context _context;
        public GetEmployeeUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetEmployeeUpdateQueryResult Handle(GetEmployeeUpdateByIDQuery query)
        {
            var values = _context.Employees.Find(query.Id);
            return new GetEmployeeUpdateQueryResult
            {
                EmployeeAge = values.EmployeeAge,
                EmployeeCity = values.EmployeeCity,
                EmployeeID = values.EmployeeID,
                EmployeeName = values.EmployeeName,
                EmployeeSalary = values.EmployeeSalary,
                EmployeeSurname = values.EmployeeSurname,
                EmployeeTitle = values.EmployeeTitle
            };
        }
    }
}
