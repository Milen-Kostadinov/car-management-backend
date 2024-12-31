namespace car_management_backend.DTOs
{
    public class CreateCarDTO
    {        
        public String Make { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public String LicensePlate { get; set; }
        public IEnumerable<long> GarageIds { get; set; }
    }
}
