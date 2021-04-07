using Health_App_mobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Health_App_mobile.Services
{
    public static class DietService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Diet.db");

            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<Diet>();
        }
        public static async Task AddDiet(string etel, string mennyiseg)
        {
            await Init();
            var diet = new Diet
            {
                Etel = etel,
                Mennyiseg = mennyiseg
            };
            var id = await db.InsertAsync(diet);
        }
        public static async Task RemoveDiet(int id)
        {
            await Init();
            await db.DeleteAsync<Diet>(id);
        }
        public static async Task<IEnumerable<Diet>> GetDiet()
        {
            await Init();
            var diet = await db.Table<Diet>().ToListAsync();
            return diet;
        }
    }
}
