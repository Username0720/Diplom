using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Grants.Models;

namespace Grants
{
    public class GrantsAsyncRepository
    {
        SQLiteAsyncConnection database;
        public GrantsAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<data_>();
        }
        public async Task<List<data_>> GetItemsAsync()
        {
            return await database.Table<data_>().ToListAsync();

        }
        public async Task<data_> GetItemAsync(int id)
        {
            return await database.GetAsync<data_>(id);
        }
        public async Task<int> DeleteItemAsync(data_ item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(data_ item)
        {
            if (item.id_d != 0)
            {
                await database.UpdateAsync(item);
                return item.id_d;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }

}