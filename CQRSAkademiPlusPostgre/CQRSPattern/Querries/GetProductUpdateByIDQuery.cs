namespace CQRSAkademiPlusPostgre.CQRSPattern.Querries
{
    public class GetProductUpdateByIDQuery
    {
        public GetProductUpdateByIDQuery(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
