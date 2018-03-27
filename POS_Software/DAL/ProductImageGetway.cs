﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ProductImageGetway:MyBase
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public int ProductId { get; set; }

        public bool Insert()
        {
            MyCommand = CommandBuilder(@"insert into productImage (productId, image, title) values(@productId, @image, @title)");
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@image", Image);
            MyCommand.Parameters.AddWithValue("@title", Title);

            return ExecuteNQ(MyCommand);
        }
        public bool Update()
        {
            MyCommand = CommandBuilder(@"update productImage set productId = @productId, image = @image, title = @title where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyCommand.Parameters.AddWithValue("@productId", ProductId);
            MyCommand.Parameters.AddWithValue("@image", Image);
            MyCommand.Parameters.AddWithValue("@title", Title);

            return ExecuteNQ(MyCommand);
        }
        public bool Delete(string ids = "")
        {
            if (ids != "")
            {
                MyCommand = CommandBuilder(@"delete from productImage where id in " + ids + "");
            }
            else
            {
                MyCommand = CommandBuilder("delete from productImage where id = @id");
                MyCommand.Parameters.AddWithValue("@id", Id);
            }
            return ExecuteNQ(MyCommand);
        }

        public bool SelectById()
        {
            MyCommand = CommandBuilder(@"select productId, image, title from productImage where id = @id");
            MyCommand.Parameters.AddWithValue("@id", Id);
            MyReader = ExecuteReader(MyCommand);

            while (MyReader.Read())
            {
                ProductId = Convert.ToInt32(MyReader["name"]);
                Image = (byte[])MyReader["image"];
                Title = MyReader["categoryId"].ToString();
                return true;
            }
            return false;
        }

        public DataSet Select()
        {
            MyCommand = CommandBuilder(@"select pi.id, pr.name as Product, pi.title, pi.image from productImage as pi left join product as pr on pi.productId = pr.id where pi.id > 0");
            if (!string.IsNullOrEmpty(Search))
            {
                MyCommand.CommandText += " and pi.title like @search";
                MyCommand.Parameters.AddWithValue("@search", "%" + Search + "%");
            }
            if (ProductId > 0)
            {
                MyCommand.CommandText += " and pr.id = @productId";
                MyCommand.Parameters.AddWithValue("@productId", ProductId);
            }
            return ExecuteDataSet(MyCommand);

        }
    }
}
