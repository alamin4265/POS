using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    class CountryGetWay:MyBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Insert()
        {
            string query = @"Insert into Country (name) Values (@name)";
            MyCommand = CommandBuilder(query);
            MyCommand.Parameters.AddWithValue("@name", Name);
            return ExecuteNQ(MyCommand);

        }
    }
}
