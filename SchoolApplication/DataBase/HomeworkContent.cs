using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolApplication.DataBase.Interface;

namespace SchoolApplication.DataBase
{
    public class HomeworkContent : IContent
    {
        /// <summary>
        /// идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// путь к файлу домашнего задания
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// имя файла домашнего задания
        /// </summary>
        public string FileName { get; set; }
        
    }
}
