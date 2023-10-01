namespace GymTracker.Domain.Entities
{
    public class Exercise
    {
        private Exercise(string name)
        {
            UpdateName(name);
        }

        public static Exercise Create(string name)
        {
            return new Exercise(name);
        }

        public int ExerciseId { get; set; }
        public string Name { get; set; }

        private void UpdateName(string name)
        {
            Name = name;
        }
    }
}
