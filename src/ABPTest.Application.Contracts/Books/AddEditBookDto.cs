using System;
using System.ComponentModel.DataAnnotations;

namespace ABPTest.Books
{
    public class AddEditBookDto
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Display(ShortName = "عنوان")]
        [Required(ErrorMessage = "لطفا عنوان را انتخاب نمایید")]
        [StringLength(128, ErrorMessage = "حداکثر تعداد کاراکتر قابل قبول 128 حرف می باشد")]
        public string Title { get; set; }

        [Display(ShortName = "عنوان انگلیسی")]
        [StringLength(128, ErrorMessage = "حداکثر تعداد کاراکتر قابل قبول 128 حرف می باشد")]
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
    }
}
