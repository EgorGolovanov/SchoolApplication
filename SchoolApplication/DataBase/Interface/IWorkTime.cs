using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    public interface IWorkTime
    {
        Guid Id { get; set; }
        DateTime StartWork { get; set; }
        DateTime EndWork { get; set; }
    }
}
