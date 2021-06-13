using ABPTest.Authors;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABPTest.Books
{
    public class Book : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        public string EnTitle { get; set; } = "";

        /// <summary>
        /// نوع
        /// </summary>
        public BookType Type { get; set; } = BookType.Undefined;

        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        public DateTime PublishDate { get; set; } = DateTime.Now;

        /// <summary>
        /// قیمت
        /// </summary>
        public float Price { get; set; } = 0;

        /// <summary>
        /// شناسه نویسنده
        /// </summary>
        [ForeignKey("Book_Author_ID")]
        public Guid AuthorID { get; set; }

        /// <summary>
        /// مشخصات نویسنده
        /// </summary>
        public Author Author { get; set; }
    }
}
