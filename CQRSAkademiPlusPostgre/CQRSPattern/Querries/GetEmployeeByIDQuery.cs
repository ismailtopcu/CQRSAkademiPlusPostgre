namespace CQRSAkademiPlusPostgre.CQRSPattern.Querries
{
    public class GetEmployeeByIDQuery
    {
        public GetEmployeeByIDQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
