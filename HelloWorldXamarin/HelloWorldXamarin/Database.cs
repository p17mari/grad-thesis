using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace HelloWorldXamarin
{
    public class Database //this connects to sqlite database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Formtest>();

        }

        public async Task<List<Formtest>> GetFormtestsAsync()
        {
            var results = await _database.QueryAsync<Formtest>("select star from formtest");//query example code
            //return await _database.Table<Formtest>().ToListAsync(); this is not as convenient
            return results;
        }

        public async Task<int> SaveFormtestAsync(Formtest formtest)
        {
            return await _database.InsertAsync(formtest);
        }
    }
}
