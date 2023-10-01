namespace GymTracker.Domain.Entities
{
    public class Workout
    {
        private Workout(int userId, string name)
        {
            UpdateUserId(userId);
            UpdateName(name);
        }

        public static Workout Create(int userId, string name)
        {
            return new Workout(userId, name);
        }

        public int WorkoutId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }

        public ICollection<Exercise> Exercises { get; private set; }

        private void UpdateUserId(int userId)
        {
            UserId = userId;
        }

        private void UpdateName(string name)
        {
            Name = name;
        }

        private void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
    }
}
