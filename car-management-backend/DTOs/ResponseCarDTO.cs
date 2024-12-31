using car_management_backend.Data.Entitities;

namespace car_management_backend.DTOs
{
    public class ResponseCarDTO
    {
        public long CarId { get; set; }
        public String Make { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public String LicensePlate { get; set; }
        public IEnumerable<ResponseGarageDTO> Garages { get; set; }
    }
}
