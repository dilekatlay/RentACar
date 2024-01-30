namespace Business
{
    public class GetCustomersByIdResponse
    {
        public GetCustomersByIdResponse(int ıd, int userId, string userFirstName, string userLastName)
        {
            Id = ıd;
            UserId = userId;
            UserFirstName = userFirstName;
            UserLastName = userLastName;
        }
        

        
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
    }
}