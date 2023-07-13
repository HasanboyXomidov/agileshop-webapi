using AgileShop.DataAccess.Interfaces.Categories;
using AgileShop.DataAccess.Utils;
using AgileShop.Domain.Entities.Categories;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.DataAccess.Repositories.Categories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public async Task<int> CountAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"select count(*) from categories";
                var result = await _connection.QuerySingleAsync<int>(query);
                return result;
            }
            catch 
            {

                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<int> CreateAsync(Category entity)
        {
            try
            {
                await _connection.OpenAsync();
                string query= "INSERT INTO public.categories(name, description, image_path, created_at, updated_at) " +
                    "VALUES (@name, @description, @ImagePath, @created_at, @updated_at);";
                var result = await _connection.ExecuteAsync(query, entity);
                return result;

            }
            catch 
            {
                return 0;

            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<int> DeleteAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string query= "DELETE FROM categories WHERE id=@Id";
                var result = await _connection.ExecuteAsync(query, new { Id = id }) ;
                return result;
            }
            catch 
            {
                return 0;                
            }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<Category>> GetAllAsync(PaginationParams @params)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"select * from categories order by id desc " +
                    $"offset {@params.GetSkipCount()} limit {@params.PageSize}";
                var result = (await _connection.QueryAsync<Category>(query)).ToList();
                return result;

            }
            catch 
            {
                return new List<Category>();                
            }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<Category> GetByIdAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"select * from categories where id={id};";
                var result = await _connection.QuerySingleAsync<Category>(query) ;
                return result;
            }
            catch 
            {
               return new Category();                
            }
            finally {
                
                await _connection.CloseAsync(); }
        }

        public async Task<int> UpdateAsync(long id, Category entity)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"UPDATE public.categories " +
                    $"SET name=@name, description=@description, image_path=@Image_path, created_at=@created_at, updated_at=@updated_at " +
                    $"WHERE id={id};";
                var result = await _connection.ExecuteAsync(query, entity);
                return result;
            }
            catch 
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }
    }
}
