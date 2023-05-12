using System.ComponentModel.DataAnnotations;

namespace SentenceBuilderWebApp.Models.DTOModels
{
    public class WordDTOCreate
    {
        [Required]
        public int WordTypeId { get; set; }

        [Required]
        public string Word { get; set; }
    }
}
