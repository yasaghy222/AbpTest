using ABPTest.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ABPTest.Authors
{
    public class AuthorDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// نام
        /// </summary>
        [Display(ShortName = "نام")]
        public string Name { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [Display(ShortName = "نام خانوادگی")]
        public string Family { get; set; }

        /// <summary>
        /// نام کامل
        /// </summary>
        [Display(ShortName = "نام کامل")]
        public string FullName => $"{Name} {Family}";

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        [Display(ShortName = "تاریخ تولد")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// لیست کتاب ها
        /// </summary>
        public ICollection<BookDto> Books { get; set; }
    }
}
