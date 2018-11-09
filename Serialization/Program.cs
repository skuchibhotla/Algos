using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    public class Tutorial
    {
        public int ID;
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {     
            // Initializing the object
            Tutorial tutObj = new Tutorial();
            tutObj.ID = 1;
            tutObj.Name = ".Net";

            // Creating the stream
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\skuch\\source\\repos\\Algos\\Strings\\stream.txt", FileMode.Create, FileAccess.Write);

            // Serializing the object
            formatter.Serialize(stream, tutObj);
            stream.Close();

            // Creating the stream object to open the file in read mode
            stream = new FileStream("C:\\Users\\skuch\\source\\repos\\Algos\\Strings\\stream.txt", FileMode.Open, FileAccess.Read);
            // Deserializing the object to get the data in Tutorial format
            Tutorial newObj = (Tutorial)formatter.Deserialize(stream);

            // Printing the result
            Console.WriteLine(newObj.ID);
            Console.WriteLine(newObj.Name);

            Console.ReadKey();


        }
    }
}
