using System;
using System.ComponentModel.DataAnnotations;

namespace ABPTest.Authors
{
    public class AddEditAuthorDto
    {
        /// <summary>
        /// نام
        /// </summary>
        [Display(ShortName = "نام")]
        [Required(ErrorMessage = "لطفا نام را وارد نمایید")]
        [StringLength(128, ErrorMessage = "حداکثر تعداد کاراکتر قابل قبول 128 حرف می باشد")]
        public string Name { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        [Display(ShortName = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا نام خانوادگی را وارد نمایید")]
        [StringLength(128, ErrorMessage = "حداکثر تعداد کاراکتر قابل قبول 128 حرف می باشد")]
        public string Family { get; set; }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        [Display(ShortName = "تاریخ تولد")]
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
    }
}
