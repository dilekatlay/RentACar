﻿namespace Business.Responses.Car
{
    public class UpdateCarResponse
    {
        public UpdateCarResponse(int ıd, int colorId, int modelId, string carState, int kilometer, int modelYear, string plate, DateTime updatedAt)
        {
            Id = ıd;
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            Plate = plate;
            UpdatedAt = updatedAt;
        }

        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public string Plate { get; set; }
        public DateTime UpdatedAt { get; set; }
       
    }
}
