namespace TrainTime_Database.Entities
{
    public class UserCredentials
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string HashedPassword { get; set; } = string.Empty;
        public bool PhoneConfirmed { get; set; } = false;
        public bool EmailConfirmed { get; set; } = false;
    }
}
