namespace car_management_backend.Data.Entitities
{
    public class Maintanance
    {
        public long MaintananceId { get; set; } 
        public long CarId { get; set; }
        public long GarageId { get; set; }
        public String ServiceType { get; set; }
        public DateTime ScheduleDate { get; set; }
    }
}
