using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABPTest.Authors
{
    public interface IAuthorAppService : IApplicationService
    {
        #region insert functions
        /// <summary>
        /// افزودن نویسنده جدید
        /// </summary>
        /// <param name="model">اطلاعات نویسنده</param>
        /// <returns></returns>
        Task<Guid> InsertAsync(AddEditAuthorDto model);

        /// <summary>
        /// افزودن تعدادی نویسنده با مشخصات داده شده
        /// </summary>
        /// <param name="models">لیست مشخصات داده شده</param>
        /// <returns></returns>
        Task<string> InsertManyAsync(List<AddEditAuthorDto> models);
        #endregion insert functions

        #region update functions
        /// <summary>
        /// ویرایش اطلاعات یک نویسنده
        /// </summary>
        /// <param name="model">اطلاعات جدید نویسنده</param>
        /// <param name="id">شناسه نویسنده</param>
        /// <returns></returns>
        Task<string> UpdateAsync(AddEditAuthorDto model, Guid id);

        /// <summary>
        /// ویرایش اطلاعات نویسندگان با شروط درخواستی
        /// </summary>
        /// <param name="model">اطلاعات جدید نویسندگان</param>
        /// <param name="conditions">شروط درخواستی مثلا : (i=> i.Title.Containes("م"))</param>
        /// <returns></returns>
        Task<string> UpdateManyAsync(AddEditAuthorDto model, Expression<Func<AuthorDto, bool>> conditions);
        #endregion update functions

        #region get functions
        /// <summary>
        /// دریافت مشخصات یک نویسنده با شناسه
        /// </summary>
        /// <param name="id">شناسه نویسنده</param>
        /// <returns></returns>
        Task<AuthorDto> GetAsync(Guid id);

        /// <summary>
        /// دریافت مشخصات یک نویسنده با شروط درخواستی
        /// </summary>
        /// <param name="id">شناسه نویسنده</param>
        /// <param name="conditions">شروط درخواستی مثلا : (i=> i.Title.Containes("م"))</param>
        /// <returns></returns>
        Task<AuthorDto> GetAsync(Expression<Func<AuthorDto, bool>> conditions);


        /// <summary>
        /// دریافت همه نویسندگان
        /// </summary>
        /// <param name="conditions">شروط درخواستی مثلا : (i=> i.Title.Containes("م"))</param>
        /// <returns></returns>
        Task<List<AuthorDto>> GetListAsync(Expression<Func<AuthorDto, bool>> conditions = null);

        /// <summary>
        /// دریافت لیست نویسندگان بصورت پیج بندی شده
        /// </summary>
        /// <param name="skipCount">تعداد مورد نظر برای رد کردن</param>
        /// <param name="maxResultCount">تعداد رکورد درخواستی</param>
        /// <param name="sortedResult">پارامتر های مدنظر برای مرتب سازی مثلا : "Title Desc" | "Title Asc, BirtDate Desc"</param>
        /// <returns></returns>
        Task<List<AuthorDto>> GetPagedListAsync(
            int skipCount,
            int maxResultCount,
            string sortedResult);

        /// <summary>
        /// دریافت تعداد نویسندگان
        /// </summary>
        /// <param name="conditions">شروط درخواستی مثلا : (i=> i.Title.Containes("م"))</param>
        /// <returns></returns>
        Task<long> GetCountAsync(Expression<Func<AuthorDto, bool>> conditions = null);
        #endregion

        #region delete functions
        /// <summary>
        /// حذف یک نویسنده با شناسه
        /// </summary>
        /// <param name="id">شناسه نویسنده</param>
        /// <returns></returns>
        Task<string> DeleteAsync(Guid id);

        /// <summary>
        /// حذف یک نویسنده با شروط درخواستی
        /// </summary>
        /// <param name="conditions">شروط درخواستی مثلا : (i=> i.Title.Containes("م"))</param>
        /// <returns></returns>
        Task<string> DeleteAsync(Expression<Func<AuthorDto, bool>> conditions);

        /// <summary>
        /// حذف تعدادی از نویسندگان با شروط درخواستی
        /// </summary>
        /// <param name="conditions">شروط درخواستی مثلا : (i=> i.Title.Containes("م"))</param>
        /// <returns></returns>
        Task<string> DeleteManyAsync(Expression<Func<AuthorDto, bool>> conditions);
        #endregion delete functions
    }
}
