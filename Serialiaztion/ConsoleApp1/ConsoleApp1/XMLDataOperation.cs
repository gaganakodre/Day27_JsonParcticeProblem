using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JsonDataOperations
{
    public class XMLDataOperation
    {
        public static void xmlSerialize()
        {
            try
            {
                string xmlpath = @"G:\visualstudio\FileIOTextFile\xmlDataOperation.xml";
                //List<Person> person = new List<Person>();
                //person.Add(new Person() { PersonId = 12, Name = "Kavitha", Address = "Bangaluru" });
                //person.Add(new Person() { PersonId = 13, Name = "Kavana", Address = "Bengal" });
                //person.Add(new Person() { PersonId = 14, Name = "Katha", Address = "Ballery" });
                Person person = new Person() { PersonId = 12, Name = "Kavitha", Address = "Bangaluru" };
                XmlSerializer xml = new XmlSerializer(typeof(Person));//it will specify the type  repreests the type declaration
                //xmlserilaizer serialize and deserilaizes the objects into and from xml formate
                StreamWriter sw = new StreamWriter(xmlpath);
                xml.Serialize(sw, person);//this seralize the object into xml type using textwriter
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    sw.Close();
            //}
        }
        public static void DXmlDeSerialize()
        {
            string xmlpath = @"G:\visualstudio\FileIOTextFile\xmlDataOperation.xml";
            using (StreamReader sr = new StreamReader(xmlpath))

            {
                if (File.Exists(xmlpath))
                {
                    Person person = new Person() { PersonId = 12, Name = "Kavitha", Address = "Bangaluru" };
                    XmlSerializer xml = new XmlSerializer(typeof(Person));
                    //sr = new StreamReader(xmlpath);
                    //deserializes the xml document into specified textwriter(streamreader)
                    Person res = (Person)xml.Deserialize(sr);//expicit catsing
                    Console.WriteLine(person);
                }
            }
        }
       
        
    }

}

