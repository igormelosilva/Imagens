using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Imagens
{
    public class Animal
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public Bitmap imageBmp { get; set; }

        public bool Add(Animal animal)
        {
            bool result = false;
            DatabaseAccess dba = new DatabaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO animals (name, image) " +
                                      @"VALUES (@name, @image);";


                    cmd.Parameters.AddWithValue("@name", animal.name);
                    cmd.Parameters.AddWithValue("@image", animal.image);
                    

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                    }
                    result = true;
                }
            }
            catch
            { }
            return result;
        }
        public bool SaveImageToFile(string sourcePath, string savePath, string name)
        {
            bool result = false;
            try
            {
                if(!Directory.Exists(savePath)) {
                    Directory.CreateDirectory(savePath);
                }
                Bitmap bitmap = new Bitmap(sourcePath);
                bitmap.Save(Path.Combine(savePath, name));
                result = true;

            }
            catch (Exception ex)
            {

                
            }
            return result;
        }
        public Animal Get(int id)
        {

            Animal result = new Animal();
            DatabaseAccess dba = new DatabaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM animals " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.name = reader["name"].ToString();
                            result.image = reader["image"].ToString();
                            result.imageBmp = new Bitmap(Path.Combine(Config.imageFolder, result.image));

                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

        public List<Animal> GetAll()
        {
            List<Animal> result = new List<Animal>();
            DatabaseAccess dba = new DatabaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * " +
                                      @"FROM animals " +
                                      @"ORDER BY id;";

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Animal animal = new Animal();

                            animal.id = Convert.ToInt32(reader["id"]);
                            animal.name = reader["name"].ToString();
                            animal.image = reader["image"].ToString();
                            animal.imageBmp = new Bitmap(Path.Combine(Config.imageFolder, animal.image));

                            result.Add(animal);
                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }


    }
}
