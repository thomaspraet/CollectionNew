using System.ComponentModel.DataAnnotations;

namespace Collection.web.Data
{
    public class Artist
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
