using Core.Entities;

namespace Entities.Concrete
{
    public class Car : Entity<int>
    {

        //Id, ColorId, ModelId, CarState, Kilometer, ModelYear, Plate
        public int Id { get; set; }
        public int ColorId { get; set; } //Renk Id
        public int ModelId { get; set; } // Model Id
        public string CarState { get; set; } // Araç durumu(0, 2. el)
        public int Kilometer { get; set; } // Kilometre min 0
        public string Plate { get; set; } // Plaka 34ABC34
        public DateTime UpdatedAt { get; set; } 

        public Car()
        {

        }

        public Car(int id, int colorId, int modelId, string carState, int kilometer, string plate)
        {
            Id = id;
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            Plate = plate;
        }
    }
}