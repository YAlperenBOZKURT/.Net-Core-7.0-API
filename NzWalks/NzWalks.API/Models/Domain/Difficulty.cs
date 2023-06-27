namespace NzWalks.API.Models.Domain
{
    public class Difficulty : BaseEntity
    {
        public string Name { get; set; }


        // Navigation properties
        public virtual Walk Walk { get; set; }

    }
}
