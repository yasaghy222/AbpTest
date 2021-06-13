using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABPTest.Books
{
    public enum BookType : byte
    {
        /// <summary>
        /// نامشخص
        /// </summary>
        [Display(Name = "نامشخص")]
        Undefined = 0,

        /// <summary>
        /// ماجراجویی
        /// </summary>
        [Display(Name = "کاجراجویی")]
        Adventure = 1,

        /// <summary>
        /// زندگینامه
        /// </summary>
        [Display(Name = "زندگینامه")]
        Biography = 1,

        /// <summary>
        /// پادآرمانی
        /// </summary>
        [Display(Name = "پادآرمانی")]
        Dystopia = 3,

        /// <summary>
        /// فانتزی
        /// </summary>
        [Display(Name = "فانتزی")]
        Fantastic = 4,

        /// <summary>
        /// وحشت
        /// </summary>
        [Display(Name = "وحشت")]
        Horror = 5,

        /// <summary>
        /// علمی
        /// </summary>
        [Display(Name = "علمی")]
        Science = 6,

        /// <summary>
        /// علمی تخیلی
        /// </summary>
        [Display(Name = "علمی تخیلی")]
        ScienceFiction = 7,

        /// <summary>
        /// شعر
        /// </summary>
        [Display(Name = "شعر")]
        Poetry = 8
    }
}
