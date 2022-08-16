namespace Domain.Entities.Core
{
    public class Entity
    {
        public DateTime CreatedAt { get;private set; }
        public DateTime UpdatedAt { get;private set; }

        public Entity()
        {
            var now = DateTime.Now;
            CreatedAt = now;
            UpdatedAt = now;
        }
    }
}
