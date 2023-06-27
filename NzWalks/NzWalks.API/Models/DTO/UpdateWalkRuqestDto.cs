using System.ComponentModel.DataAnnotations;

namespace NzWalks.API.Models.DTO
{
    public class UpdateWalkRuqestDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name has to be a maximum of 100 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(1000, ErrorMessage = "Name has to be a maximum of 1000 characters")]
        public string Description { get; set; }
        [Required]
        [Range(0, 50)]
        public double LengthInKm { get; set; }
        public string? WalkImgUrl { get; set; }

        [Required]
        public Guid DifficultyID { get; set; }
        [Required]
        public Guid RegionID { get; set; }
    }
}
