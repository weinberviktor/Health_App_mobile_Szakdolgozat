using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Health_App_mobile.Models
{
    public class Diet
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Etkezes { get; set; }
        public string Etel { get; set; }
        public string Mennyiseg { get; set; }
    }
}
