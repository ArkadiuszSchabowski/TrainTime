using TrainTime.Enums;

namespace TrainTime_Database.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;
        public bool PhoneConfirmed { get; set; } = false;
        public string Email { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;
        public UserType UserType { get; set; } = UserType.User;
        public List<UserGym> UserGyms { get; set; } = new();
        public List<BookedTraining> BookedTrainings {get; set;} = new();
        public Trainer? Trainer { get; set; }
    }
}
