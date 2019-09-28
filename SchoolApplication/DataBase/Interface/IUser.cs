using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase
{
    public interface IUser
    {
        Guid Id { get; set; }
        string DiscordName { get; set; }
        Role Role { get; set; }
    }
}
