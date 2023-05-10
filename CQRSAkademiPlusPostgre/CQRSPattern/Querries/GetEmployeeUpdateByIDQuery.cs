namespace CQRSAkademiPlusPostgre.CQRSPattern.Querries
{
    public class GetEmployeeUpdateByIDQuery
    {
        public GetEmployeeUpdateByIDQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
