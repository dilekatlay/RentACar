namespace Business.Responses.Model
{
    public class UpdateModelResponse
    {//Id, BrandId, FuelId, TransmissionId, Name, DailyPrice


        public int Id { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public string Name { get; set; }
        public short Year { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime UpdatedAt { get; set; }
        

    }
}