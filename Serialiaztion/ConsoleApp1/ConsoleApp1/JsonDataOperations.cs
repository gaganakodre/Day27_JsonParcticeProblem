using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JsonDataOperations
{
    class JsonDataOperations
    {
        public static void jsonSerialize()
        {
            string jsonPath= @"G:\visualstudio\FileIOTextFile\JsonTextFile.json";
            
            //Collection intializer
            List<Person> person=new List<Person>();
            person.Add(new Person() { PersonId = 12, Name = "Kavitha", Address = "Bangaluru" });
            person.Add(new Person() { PersonId = 13, Name = "Kavana", Address = "Bengal" });
            person.Add(new Person() { PersonId = 14, Name = "Katha", Address = "Ballery" });
            string result = JsonConvert.SerializeObject(person);//objcet to string
            using (StreamWriter sw = new StreamWriter(jsonPath)) 
            {
                sw.Write(result);
            }
            
        }
        
        public static void JsonDeserialization()//string to object
        {
            string jsonPath = @"G:\visualstudio\FileIOTextFile\JsonTextFile.json";
            if(FileExist(jsonPath))
            {
                string JsonData=File.ReadAllText(jsonPath);
                var result=JsonConvert.DeserializeObject<List<Person>>(JsonData);
                foreach(Person person in result)
                {
                    
                    Console.WriteLine(person.ToString());
                }
                
            }
            else
            {
                Console.WriteLine("File not exist");
            }

            

        }
        public static bool FileExist(string path)
        {
            string InputFile = @"G:\visualstudio\FileIOTextFile\JsonTextFile.json";
            if (File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
                return true;
            }
            else
            {
                Console.WriteLine("not Exist");
                return false;
            }
        }
    }
    
}
