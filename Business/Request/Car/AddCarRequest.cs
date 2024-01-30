namespace Business.Request.Car
{
    public class AddCarRequest
    {
        public AddCarRequest(int id, int colorId, int modelId, string carState, int kilometer, int modelYear, string plate)
        {
            Id = id;
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