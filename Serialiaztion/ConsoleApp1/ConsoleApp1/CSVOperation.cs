using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataOperations
{
    public class CSVOperation
    {
        public static void csvSerilaization()
        {
            try
            {
                string csvpath = @"G:\visualstudio\FileIOTextFile\DataOperationCSV.csv";
                List<Person> person = new List<Person>();
                person.Add(new Person() { PersonId = 12, Name = "Kavitha", Address = "Bangaluru" });
                person.Add(new Person() { PersonId = 13, Name = "Kavana", Address = "Bengal" });
                person.Add(new Person() { PersonId = 14, Name = "Katha", Address = "Ballery" });

                //steams are like sequence of bytes
                using (StreamWriter sw = new StreamWriter(csvpath))
                { 
                    //cultureinfo - it provides the specific information like in local eg:calander style etc 
                    //csv writer from the csv helper class
                    CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);//returns the object which is cultur inpedendent
                    //this has to be written to write the records inside the file
                    csvWriter.WriteRecords(person);//write records used to write list of records inside the csvfile
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static List<Person> CSVDeserialize()
        {
            try
            {
                string csvpath = @"G:\visualstudio\FileIOTextFile\DataOperationCSV.csv";
                StreamReader sr = new StreamReader(csvpath);//it initializes a new instance of streamreader class
                CsvReader cr = new CsvReader(sr, CultureInfo.InvariantCulture);
                List<Person> res = cr.GetRecords<Person>().ToList();//it will get the all the records inside the csv file
                                                                    //and converts into each type
                foreach (Person person in res)
                {
                    Console.WriteLine(person);
                }
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

    }


}

//o/p after csv deserialization
//Enter the choice you want 1.JsonSerialization
// 2.jsonDeserializeation
// 3.XMLserialization
// 4.XMLDeserialization
// 5.CSVSerialization
// 6.CSVdeserialization
//6
//Id:  12 Name: Kavitha Address:  Bangaluru
//Id:  13 Name: Kavana Address:  Bengal
//Id:  14 Name: Katha Address:  Ballery
