using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    public class Schedule
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// дата контента
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// преподаватель, ведущий контент
        /// </summary>
        public Teacher Teacher { get; set; }
        /// <summary>
        /// тип контента (вебинар, и т.д.)
        /// </summary>
        public string TypeOfContent { get; set; }
    }
}
