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
            List<Person> person = new List<Person>();
            person.Add(new Person() { PersonId = 12, Name = "Kavitha", Address = "Bangaluru" });
            person.Add(new Person() { PersonId = 13, Name = "Kavana", Address = "Bengal" });
            person.Add(new Person() { PersonId = 14, Name = "Katha", Address = "Ballery" });
            //jsonconvert provide the methods to convert between .net to json
            //serializeobject it serilaizes the specified object into json formate
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
                
                string JsonData=File.ReadAllText(jsonPath);//read all the text in the file and closes the file
                //deserialize this deserilaizes method for converting json into .net
                List<Person> result=JsonConvert.DeserializeObject<List<Person>>(JsonData);
                if(result.Count!=0)
                foreach(Person person in result)
                {
                    
                    Console.WriteLine(person.ToString());
                }
                //return result;
                
            }
            else
            {
                Console.WriteLine("File not exist");
            }
            //return null;

            

        }
        public static bool FileExist(string path)
        {
            string InputFile = @"G:\visualstudio\FileIOTextFile\JsonTextFile.json";
            if (File.Exists(InputFile))//weather file exist or not//returns boolean values
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
////o/p:
//Enter the choice you want
// 1.JsonSerialization
// 2.jsonDeserializeation
// 3.XMLserialization
// 4.XMLDeserialization
// 5.CSVSerialization
// 6.CSVdeserialization
// 7.ReadFreomCsvWriteToJson
// 8.ReadFromJsonWriteIntoCsv
//case1
//[{"PersonId":12,"Name":"Kavitha","Address":"Bangaluru"},
//{ "PersonId":13,"Name":"Kavana","Address":"Bengal"},
//{ "PersonId":14,"Name":"Katha","Address":"Ballery"}]
//2
//File Exist
//Id:  12 Name: Kavitha Address:  Bangaluru
//Id:  13 Name: Kavana Address:  Bengal
//Id:  14 Name: Katha Address:  Ballery
