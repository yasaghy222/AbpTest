using System;
using ABPTest.Authors;
using Volo.Abp.Application.Dtos;
using System.ComponentModel.DataAnnotations;

namespace ABPTest.Books
{
    public class BookDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Display(ShortName = "عنوان")]
        public string Title { get; set; }

        [Display(ShortName = "عنوان انگلیسی")]
        public string EnTitle { get; set; } = "";

        /// <summary>
        /// نوع
        /// </summary>
        [Display(ShortName = "نوع")]
        public BookType Type { get; set; } = BookType.Undefined;

        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        [Display(ShortName = "تاریخ انتشار")]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        /// <summary>
        /// قیمت
        /// </summary>
        [Display(ShortName = "قیمت")]
        public float Price { get; set; } = 0;

        /// <summary>
        /// شناسه نویسنده
        /// </summary>
        [Display(ShortName = "شناسه نویسنده")]
        public Guid AuthorID { get; set; }

        /// <summary>
        /// مشخصات نویسنده
        /// </summary>
        public AuthorDto Author { get; set; }
    }
}
