namespace JsonDataOperations
{
    class Program
    {
        public static void Main(string[]args)
        {
            //JsonDataOperations.jsonSerialize();

            //JsonDataOperations.JsonDeserialization();
            XMLDataOperation xml = new XMLDataOperation();
            //XMLDataOperation.voidxmlSerialize();
            XMLDataOperation.DXmlDeSerialize();
            Console.ReadLine();
            //add switch case here

        }
        
    }
}