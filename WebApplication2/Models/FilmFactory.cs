using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class FilmFactory
    {
        public static IEnumerable<Film> CreateFilm()
        {
            var film = new List<Film>
            {
                new Film()
                {
                    name = "Бойцовский клуб",
                    author = "(Дэвид Финчер)",
                    description ="Терзаемый хронической бессонницей и отчаянно пытающийся вырваться из мучительно скучной жизни, клерк встречает некоего Тайлера Дардена.."
                },
                new Film()
                {
                    name = "Криминальное чтиво",
                    author = "(Квентин Тарантино)",
                    description = @"Спроси у Марселаса Уолоса"
                },
                new Film()
                {
                    name = "В центре внимания",
                    author = "(Том МакКарти)",
                    description = "Оскаровский свежачок"
                }
            };

            return film;
        }
    }
}