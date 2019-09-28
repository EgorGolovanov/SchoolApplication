using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    public class Chanell
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя канала
        /// </summary>
        public string ChanellName { get; set; }
        /// <summary>
        /// список ролей доступных для канала
        /// </summary>
        public List<Role> Roles { get; set; }
        /// <summary>
        /// список команд доступных для канала
        /// </summary>
        public List<Command> Commands { get; set; }
    }
}
