using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    public interface IChanell
    {
        Guid Id { get; set; }
        string ChanellName { get; set; }
        List<Role> Roles { get; set; }
        List<Command> Commands { get; set; }
    }
}
