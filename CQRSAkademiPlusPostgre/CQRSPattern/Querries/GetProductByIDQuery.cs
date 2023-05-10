namespace CQRSAkademiPlusPostgre.CQRSPattern.Querries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        
    }

}
