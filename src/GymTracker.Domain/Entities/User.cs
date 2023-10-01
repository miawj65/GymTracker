namespace GymTracker.Domain.Entities
{
    public class User
    {
        private User(string username)
        {
            UpdateUsername(username);
        }

        public static User Create(string username)
        {
            return new User(username);
        }

        public int UserId { get; set; }
        public string Username { get; set; }

        public ICollection<Workout> Workouts { get; private set; }

        private void UpdateUsername(string username)
        {
            Username = username;
        }

        private void AddWorkout(Workout workout)
        {
            Workouts.Add(workout);
        }
    }
}
