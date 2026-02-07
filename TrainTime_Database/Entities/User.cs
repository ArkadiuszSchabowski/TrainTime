using TrainTime.Enums;

namespace TrainTime_Database.Entities
{
    public class User
    {
        public int Id { get; set; }
        public UserCredentials? UserCredentials { get; set; }
        public UserDetails? UserDetails {  get; set; }
        public List<UserGym> UserGyms { get; set; } = new();
        public List<BookedTraining> BookedTrainings {get; set;} = new();
    }
}
