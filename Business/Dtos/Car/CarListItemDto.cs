using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Car
{
    public class CarListItemDto
    {
        public int Id { get; set; }
        public int colorId { get; set; }
        public int modelId { get; set; }
        public string carState { get; set; }
        public float kilometer { get; set; }
        public string plate { get; set; }

    }
}
