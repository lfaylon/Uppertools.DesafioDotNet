using System.ComponentModel.DataAnnotations;

namespace Uppertools.DesafioDotNet.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}