using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ABPTest.Authors
{
    public class AuthorAppService : ABPTestAppService, IAuthorAppService
    {
        #region variables
        private Author Author { get; set; }
        private long Count { get; set; } = 0;
        private List<Author> Authors { get; set; }
        private Expression<Func<Author, bool>> DBCondition { get; set; }

        protected readonly IRepository<Author, Guid> _repo;
        #endregion

        public AuthorAppService(IRepository<Author, Guid> repo) => _repo = repo;

        #region delete functions
        public async Task<string> DeleteAsync(Guid id)
        {
            try
            {
                Author = await _repo.GetAsync(id);
                await _repo.DeleteAsync(Author);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DeleteAsync(Expression<Func<AuthorDto, bool>> conditions)
        {
            try
            {
                DBCondition = conditions.As<Expression<Func<Author, bool>>>();
                Author = await _repo.GetAsync(DBCondition);
                await _repo.DeleteAsync(Author);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DeleteManyAsync(Expression<Func<AuthorDto, bool>> conditions)
        {
            try
            {
                DBCondition = conditions.As<Expression<Func<Author, bool>>>();
                Authors = await _repo.GetListAsync(DBCondition);
                await _repo.DeleteManyAsync(Authors);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region get functions
        public async Task<AuthorDto> GetAsync(Guid id)
        {
            try
            {
                Author = await _repo.GetAsync(id);
                return ObjectMapper.Map<Author, AuthorDto>(Author);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<AuthorDto> GetAsync(Expression<Func<AuthorDto, bool>> conditions)
        {
            try
            {
                DBCondition = conditions.As<Expression<Func<Author, bool>>>();
                Author = await _repo.GetAsync(DBCondition);
                return ObjectMapper.Map<Author, AuthorDto>(Author);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<long> GetCountAsync(Expression<Func<AuthorDto, bool>> conditions = null)
        {
            try
            {
                if (conditions == null)
                {
                    Count = await _repo.GetCountAsync();
                }
                else
                {
                    DBCondition = conditions.As<Expression<Func<Author, bool>>>();
                    Count = await _repo.CountAsync(DBCondition);
                }

                return Count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<List<AuthorDto>> GetListAsync(Expression<Func<AuthorDto, bool>> conditions = null)
        {
            try
            {
                DBCondition = conditions.As<Expression<Func<Author, bool>>>();
                Authors = await _repo.GetListAsync(DBCondition);
                return ObjectMapper.Map<List<Author>, List<AuthorDto>>(Authors);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<AuthorDto>> GetPagedListAsync(int skipCount, int maxResultCount, string sortedResult)
        {
            try
            {
                Authors = await _repo.GetPagedListAsync(skipCount, maxResultCount, sortedResult);
                return ObjectMapper.Map<List<Author>, List<AuthorDto>>(Authors);
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion get functions


        #region insert functions
        public async Task<Guid> InsertAsync(AddEditAuthorDto model)
        {
            try
            {
                Author = ObjectMapper.Map<AddEditAuthorDto, Author>(model);
                Author = await _repo.InsertAsync(Author, autoSave: true);
                return Author.Id;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        public async Task<string> InsertManyAsync(List<AddEditAuthorDto> models)
        {
            try
            {
                Authors = ObjectMapper.Map<List<AddEditAuthorDto>, List<Author>>(models);
                await _repo.InsertManyAsync(Authors, autoSave: true);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion insert functions


        #region update functions
        public async Task<string> UpdateAsync(AddEditAuthorDto model, Guid id)
        {
            try
            {
                Author = await _repo.GetAsync(id);
                Author.Name = model.Name ?? Author.Name;
                Author.Family = model.Family ?? Author.Family;
                Author.BirthDate = model.BirthDate == DateTime.MinValue
                    ? Author.BirthDate : model.BirthDate;

                await _repo.UpdateAsync(Author);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> UpdateManyAsync(AddEditAuthorDto model, Expression<Func<AuthorDto, bool>> conditions)
        {
            try
            {
                DBCondition = conditions.As<Expression<Func<Author, bool>>>();
                Authors = await _repo.GetListAsync(DBCondition);
                foreach (Author author in Authors)
                {
                    author.Name = model.Name ?? author.Name;
                    author.Family = model.Family ?? author.Family;
                    author.BirthDate = model.BirthDate == DateTime.MinValue
                        ? author.BirthDate : model.BirthDate;
                }

                await _repo.UpdateManyAsync(Authors, autoSave: true);
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion update functions
    }
}
