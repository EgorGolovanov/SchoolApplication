using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    public class FreeContentSchedule
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// список ролей которые могут получить расписание
        /// </summary>
        public List<Role> Roles { get; set; }
        /// <summary>
        /// расписание бесплатного контента
        /// </summary>
        public Schedule Schedule { get; set; }
    }
}
