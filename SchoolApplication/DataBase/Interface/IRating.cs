using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    public interface IRating<T> where T : IUser
    {
        Guid Id { get; set; }
        /// <summary>
        /// лист чего то
        /// </summary>
        List<T> RatingList { get; set; }
        int PositionOfRating { get; set; }
    }
}
