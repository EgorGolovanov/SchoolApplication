using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication.DataBase.Interface
{
    public interface IContent
    {
        Guid Id { get; set; }
        string FileName { get; set; }
        string File { get; set; }
    }
}
