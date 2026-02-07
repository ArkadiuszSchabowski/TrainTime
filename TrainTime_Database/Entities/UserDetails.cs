using TrainTime.Enums;

namespace TrainTime_Database.Entities
{
    public class UserDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public UserType UserType { get; set; } = UserType.User;
        public Trainer? Trainer { get; set; }
    }
}
