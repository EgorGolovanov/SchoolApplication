using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    public class Methodist : IUser
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// имя методиста
        /// </summary>
        public string DiscordName { get; set; }
        /// <summary>
        /// роль методиста
        /// </summary>
        public Role Role { get; set; }
    }
}
