using ABPTest.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABPTest.Authors
{
    public class Author : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// لیست کتاب ها
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}
