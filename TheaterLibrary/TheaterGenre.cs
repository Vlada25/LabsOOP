using System.ComponentModel.DataAnnotations;

namespace TheaterLibrary
{
    public enum TheaterGenre
    {
        [Display(Name = "Драма")]
        Drama,

        [Display(Name = "Комедия")]
        Comedy,

        [Display(Name = "Мим")]
        Mime,

        [Display(Name = "Мелодрама")]
        Melodrama,

        [Display(Name = "Пародия")]
        Parody,

        [Display(Name = "Трагедия")]
        Tragedy,

        [Display(Name = "Феерия")]
        Extravaganza,

        [Display(Name = "Мюзикл")]
        Musical
    }
}
