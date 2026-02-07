namespace TrainTime_Database.Entities
{
    public class UserGym
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int GymId { get; set; }
        public Gym? Gym { get; set; }
    }
}
