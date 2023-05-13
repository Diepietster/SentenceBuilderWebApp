using System.ComponentModel.DataAnnotations;

namespace SentenceBuilderWebApp.Models
{
    public class Words
    {
        public int WordId { get; set; }

        [Required]
        public int WordTypeId { get; set; }

        [Required]
        public string Word { get; set; }
    }
}
