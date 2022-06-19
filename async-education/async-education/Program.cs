using System.Threading.Tasks;

namespace async_education
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateFileStream.RunTask();
            ReadDataStream.StartReading();       
        }
    }
}