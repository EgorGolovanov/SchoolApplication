using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace SchoolApplication.DataBase
{
    public class Admin : IUser
    {
        public Guid Id { get; set; }
        /// <summary>
        /// имя администратора
        /// </summary>
        public string DiscordName { get; set; }
        /// <summary>
        /// роль администратора
        /// </summary>
        public Role Role { get; set; }
    }
}
