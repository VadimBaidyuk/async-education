using System;
using System.IO;
using System.Threading.Tasks;

namespace async_education
{
    public class ReadDataStream
    {
        public static async void StartReading() =>
            await LoopReading();

        private static async Task LoopReading()
        {
            ClearConsole();
                
            await Task.Delay(TimeSpan.FromSeconds(1));
                
            ReadTask.Wait();
        }

        private static Task ReadTask = Task.Factory.StartNew(() =>
        {
            var size = new FileInfo(CreateFileStream.FileStream.Name).Length;
            var fileName = CreateFileStream.FileStream.Name.TrimStart(CreateFileStream.FolderPath.ToCharArray());
            Console.WriteLine($"{fileName}", $"{size}");
        });

        private static void ClearConsole() => 
            Console.Clear();
    }
}