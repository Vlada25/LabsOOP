using System;
using System.Collections.Generic;
using System.Text;

namespace TheaterLibrary
{
    public class PlayFactory
    {
        public static Play CreatePlay(string name, string genreStr, DateTime startDate, DateTime endDate, int countOfVisits)
        {
            TheaterGenre genre = TheaterGenre.Drama;
            bool isGenreCorrect = false;

            switch (genreStr)
            {
                case "Драма":
                    genre = TheaterGenre.Drama;
                    isGenreCorrect = true;
                    break;
                case "Комедия":
                    genre = TheaterGenre.Comedy;
                    isGenreCorrect = true;
                    break;
                case "Мим":
                    genre = TheaterGenre.Mime;
                    isGenreCorrect = true;
                    break;
                case "Мелодрама":
                    genre = TheaterGenre.Melodrama;
                    isGenreCorrect = true;
                    break;
                case "Пародия":
                    genre = TheaterGenre.Parody;
                    isGenreCorrect = true;
                    break;
                case "Трагедия":
                    genre = TheaterGenre.Tragedy;
                    isGenreCorrect = true;
                    break;
                case "Феерия":
                    genre = TheaterGenre.Extravaganza;
                    isGenreCorrect = true;
                    break;
                case "Мюзикл":
                    genre = TheaterGenre.Musical;
                    isGenreCorrect = true;
                    break;
            }

            if (!isGenreCorrect)
            {
                throw new Exception("Genre is not correct");
            }

            Play play = new Play(name, genre, startDate, endDate, countOfVisits);
            return play;
        }
    }
}
