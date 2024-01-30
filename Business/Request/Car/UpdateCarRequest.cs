namespace Business.Request.Car
{
    public class UpdateCarRequest
    {
        public UpdateCarRequest(int id, int colorId, int modelId, string carState, int kilometer, int modelYear, string plate)
        {
            Id = Id;
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            Plate = plate;
        }

        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public string Plate { get; set; }
    }
}