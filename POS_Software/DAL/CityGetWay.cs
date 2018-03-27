using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CityGetWay:MyBase
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Insert()
        {
            string query = @"Insert into City (name) Values (@name)";
            MyCommand = CommandBuilder(query);            
            MyCommand.Parameters.AddWithValue("@name", Name);
            return ExecuteNQ(MyCommand);
            
        }
        public bool Update()
        {
            error = "";
            Connection();
            string query = @"Update City set name=@name where id=@id";
            MyCommand = CommandBuilder(query);
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@name", Name);
            return ExecuteNQ(MyCommand);
        }
        public bool Delete()
        {
            string query = @"Delete From City where id=@id";
            MyCommand = CommandBuilder(query);
            MyCommand.Parameters.AddWithValue("@id", Id);
            return ExecuteNQ(MyCommand);
        }
        public bool SelectById()
        {
            string query = @"Select id,name From City where id=@id";
            MyCommand = CommandBuilder(query);
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyReader = ExecuteReader(MyCommand);
            while(MyReader.Read())
            {
                Id = Convert.ToInt32(MyReader["id"].ToString());
                Name = MyReader["name"].ToString();
                return true;
            }
            return false;
        }
        public DataSet Select()
        {
            MyCommand = CommandBuilder("select id, name, origin from brand");
            if (!string.IsNullOrEmpty(Search))
            {
                MyCommand.CommandText += " where (name like @search or origin like @search)";
                MyCommand.Parameters.AddWithValue("@search", "%" + Search + "%");
            }
            return ExecuteDataSet(MyCommand);
        }


    }
}