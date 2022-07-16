using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataOperations
{
    public class JsonAndCSVOperation
    {
        public static void ReadFromCsvWriteIntoJson()
        {
            string jsonpath = @"G:\visualstudio\FileIOTextFile\jsonDataOperation.json";
            List<Person> list = CSVOperation.CSVDeserialize();//csv deserialization
            //jsonSerialize();
            string result = JsonConvert.SerializeObject(list);//json serialization
            //objcet to string

            using (StreamWriter sw = new StreamWriter(jsonpath))
            {
                sw.Write(result);
            }

        }
        
        public static void ReadFromJsonWriteIntoCsv()
        {
            string csvpath = @"G:\visualstudio\FileIOTextFile\JsontocsvTextFile.csv";
            List<Person> persons = JsonDeserialization();//json deserialization
            csvSerilaization(persons, csvpath);//csv serilaization

        }
        public static List<Person> JsonDeserialization()//string to object
        {
             string jsonPath = @"G:\visualstudio\FileIOTextFile\JsonTextFile.json";
            if (FileExist(jsonPath))
            {

                string JsonData = File.ReadAllText(jsonPath);
                List<Person> result = JsonConvert.DeserializeObject<List<Person>>(JsonData);
                if (result.Count != 0)
                    foreach (Person person in result)
                    {

                        Console.WriteLine(person.ToString());
                    }
                return result;

            }
            else
            {
                Console.WriteLine("File not exist");
            }
            return null;



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
        public static void csvSerilaization(List<Person> person, string csvpath)
        {
            try
            {
                


                using (StreamWriter sw = new StreamWriter(csvpath))
                {

                    CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    //this has to be written to write the records inside the file
                    csvWriter.WriteRecords(person);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
