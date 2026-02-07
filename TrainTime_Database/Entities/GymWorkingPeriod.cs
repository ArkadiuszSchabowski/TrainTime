namespace TrainTime_Database.Entities
{
    public class GymWorkingPeriod
    {
        public int Id { get; set; }
        public int GymId { get; set; }
        public Gym? Gym { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
    }
}
