
using System.Collections.Generic; 
using System.Threading.Tasks;
using SQLite;
using SafetyandSecurityMPApp.Models;

namespace SafetyandSecurityMPApp.Data
{
    public class CommunicationDatabase
    {
        readonly SQLiteAsyncConnection database;

        public CommunicationDatabase(string dbPath)

        {

            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<UserProfile>().Wait();

        }

        public Task<List<UserProfile>> GetItemsAsync()
        {
            return database.Table<UserProfile>().ToListAsync();
        }

        public Task<List<UserProfile>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<UserProfile>("SELECT * FROM [ChatDataBase] WHERE [Done] = 0");
        }

        public Task<UserProfile> GetItemAsync(int id)
        {
            return database.Table<UserProfile>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(UserProfile item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(UserProfile item)
        {
            return database.DeleteAsync(item);
        }
    }
}
