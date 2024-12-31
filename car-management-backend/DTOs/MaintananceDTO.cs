using car_management_backend.Data.Entitities;

namespace car_management_backend.DTOs
{
    public class MaintananceDTO
    {
        public long MaintananceId { get; set; }
        public long CarId { get; set; }
        public String CarName { get; set; } 
        public String ServiceType { get; set; }
        public DateTime ScheduleDate { get; set; }
        public long GarageId { get; set; }
        public string GarageName { get; set; }
    }
}
