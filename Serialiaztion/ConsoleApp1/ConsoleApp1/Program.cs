namespace JsonDataOperations
{
    class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the choice you want \n 1.JsonSerialization\n 2.jsonDeserializeation\n 3.XMLserialization\n 4.XMLDeserialization\n 5.CSVSerialization\n 6.CSVdeserialization\n 7.ReadFreomCsvWriteToJson\n 8.ReadFromJsonWriteIntoCsv");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:

                    JsonDataOperations.jsonSerialize();
                    break;
                case 2:
                    JsonDataOperations.JsonDeserialization();
                    break;
                case 3:
                    XMLDataOperation.xmlSerialize();
                    break;
                case 4:
                    XMLDataOperation.DXmlDeSerialize();
                    break;
                case 5:
                    CSVOperation.csvSerilaization();
                    break;
    
                case 6:
                    CSVOperation.CSVDeserialize();
                    break;
                case 7:
                    JsonAndCSVOperation.ReadFromCsvWriteIntoJson();
                    break;
                case 8:
                    JsonAndCSVOperation.ReadFromJsonWriteIntoCsv();
                    break;


            }
            

        }
        
    }
}
//o/p:case 3 inside the xml file
//<? xml version = "1.0" encoding = "utf-8" ?>< Person xmlns:xsi = "http://www.w3.org/2001/XMLSchema-instance" xmlns: xsd = "http://www.w3.org/2001/XMLSchema" >
//< PersonId > 12 </ PersonId >
//< Name > Kavitha </ Name >
//< Address > Bangaluru </ Address ></ Person >

//o/p case 4
//4
//Id: 12 Name: Kavitha Address:  Bangaluru

//case 5
//PersonId,Name,Address
//12,Kavitha,Bangaluru
//13,Kavana,Bengal
//14,Katha,Ballery

//case 6
//6
//Id: 12 Name: Kavitha Address:  Bangaluru
//Id:  13 Name: Kavana Address:  Bengal
//Id:  14 Name: Katha Address:  Ballery

//o/prop:case7:
//Enter the choice you want
//1.JsonSerialization
// 2.jsonDeserializeation
// 3.XMLserialization
// 4.XMLDeserialization
// 5.CSVSerialization
// 6.CSVdeserialization
// 7.ReadFreomCsvWriteToJson
//7
//Id: 12 Name: Kavitha Address:  Bangaluru
//Id:  13 Name: Kavana Address:  Bengal
//Id:  14 Name: Katha Address:  Ballery
//and everything stored in csv then write to the json file

//case 8:
//Enter the choice you want
// 1.JsonSerialization
// 2.jsonDeserializeation
// 3.XMLserialization
// 4.XMLDeserialization
// 5.CSVSerialization
// 6.CSVdeserialization
// 7.ReadFreomCsvWriteToJson
// 8.ReadFromJsonWriteIntoCsv
//8
//File Exist
//Id:  12 Name: Kavitha Address:  Bangaluru
//Id:  13 Name: Kavana Address:  Bengal
//Id:  14 Name: Katha Address:  Ballery