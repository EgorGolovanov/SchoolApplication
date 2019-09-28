using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    public class ContestContent : IContent
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// путь к файлу вопроса конкурса
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// имя файла вопроса
        /// </summary>
        public string FileName { get; set; }
       
    }
}
