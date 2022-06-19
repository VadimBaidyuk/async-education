using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace async_education
{
    public class CreateFileStream
    {
        public const string FolderPath = "D:\\_prj\\async-education\\async-education\\async-education\\Artists\\";
        public static FileStream FileStream { get; private set; }
        
        public static async Task RunTask()
        {
            await Task.Delay(TimeSpan.FromSeconds(new Random().Next(1,20)));
                
            await CreateFileTask();
        }

        private static async Task CreateFileTask() => 
            await Task.Run(CreateFile);

        private static Task CreateFile()
        {
            var random = new Random(); 
            FileStream = File.Create(FolderPath + UkrainianArtist.Artists
                .ElementAt(random.Next(0, UkrainianArtist.Artists.Count)));

            FileStream.Close();
            File.WriteAllText(FileStream.Name, RandomString(random.Next(1, 2000)));

            return null;
        }

        private static string RandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}