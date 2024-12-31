namespace car_management_backend.DTOs
{
    public class GarageQueryDTO
    {
        public DateTime Date { get; set; }
        public int Requests { get; set; }
        public int availableCapacity { get; set; }
    }
}
