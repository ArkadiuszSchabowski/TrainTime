namespace TrainTime_Database.Entities
{
    public class Trainer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public  string? Description { get; set; }
        public List<TrainerWorkingPeriod> WorkingPeriods { get; set; } = new();
    }
}