using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class TextMessage
    {
        [Required]
        [Phone]
        public string FromNumber { get; set; }

        [Required]
        [Phone]
        public string ToNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(140)]
        public string Content { get; set; }

        public override string ToString()
        {
            return String.Format("From: {0} | To: {1} | Message: {2}", FromNumber, ToNumber, Content);
        }

    }
}
