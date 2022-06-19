using System;
using System.IO;
using System.Threading.Tasks;

namespace async_education
{
    public class ReadDataStream
    {
        public static void StartReading()
        {
            ReadTask.Wait();
        }

        private static Task ReadTask = Task.Factory.StartNew(() =>
        {
            var size = new FileInfo(CreateFileStream.FileStream.Name).Length;
            Console.WriteLine(size);
        }); 
    }
}