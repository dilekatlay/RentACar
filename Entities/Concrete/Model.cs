using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int> 
{
    public int BrandId { get; set; } // normalizasyon // Marka ıdsi
    public int FuelId { get; set; } // yakıt ıd
    public int TransmissionId { get; set; } // şanzıman tipi otomatik, manuel, yarı otomatik
    public string Name { get; set; } 
    public short Year { get; set; } // Model yılı
    public decimal DailyPrice { get; set; } // Günlük ücret 

    public Model() { }

    public Model(
        int brandId,
        int fuelId,
        int transmissionId,
        string name,
        short year,
        decimal dailyPrice
    )
    {
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
    }

    // lazy loading
    public Brand? Brand { get; set; } = null; // one-to-one ilişki var.
    public Fuel? Fuel { get; set; } = null; // one-to-one ilişki var.
    public Transmission? Transmission { get; set; } = null; // one-to-one ilişki var.

    //public ICollection<Car>? Cars { get; set; } = null; // model ile car arasında one-to-many ilişki var.
}