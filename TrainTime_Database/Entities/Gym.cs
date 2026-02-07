namespace TrainTime_Database.Entities
{
    public class Gym
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<UserGym> UserGyms { get; set; } = new();
        public List<GymWorkingPeriod> WorkingPeriods {get; set;} = new();
    }
}
