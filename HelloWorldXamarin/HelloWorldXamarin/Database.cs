using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace HelloWorldXamarin
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Teacher>().Wait();
        }

        public async Task<List<Teacher>> GetTeachersAsync() { //async needs await in the return afterwards

           var results = await _database.QueryAsync<Teacher>("select * from teacher");//query example code
           // return await _database.Table<Teacher>().ToListAsync(); //this is not as convenient
            return results;
        }

        public async Task<int> SaveTeacherAsync(Teacher teacher)
        {
            return await _database.InsertAsync(teacher);
        } 

    }
}