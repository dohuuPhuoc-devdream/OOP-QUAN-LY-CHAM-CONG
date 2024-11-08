using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace WinFormsApp6
{
    public class FileManager<T>
    {
        // Phương thức để lưu trữ dữ liệu vào file JSON
        public void SerializeData(List<T> data, string filePath)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error serializing data: " + ex.Message);
            }
        }

        // Phương thức để tải dữ liệu từ file JSON
        public List<T> DeserializeData(string filePath)
        {
            List<T> data = new List<T>();

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    data = JsonConvert.DeserializeObject<List<T>>(jsonData);
                }
                else
                {
                    Console.WriteLine("File not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deserializing data: " + ex.Message);
            }

            return data;
        }
    }
}
