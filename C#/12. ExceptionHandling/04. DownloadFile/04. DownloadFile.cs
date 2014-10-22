using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
// and stores it the current directory. Find in Google how to download files in C#. 
// Be sure to catch all exceptions and to free any used resources in the finally block.

class DownloadFile
{
    static void Main(string[] args)
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                //Console.WriteLine("Enetr URL for downloading: ");
                //string path = Console.ReadLine();                     // if yoy want to try with another file :(
                //client.DownloadFile(path, "image.jpg");

                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "image.jpg");
                Console.WriteLine("File successfully downloaded.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter must not be null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error while downloading file.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method DownloadFile() cannot be called simultaneously on multiple threads.");
            }
            finally
            {
                Console.WriteLine("Bye-bye!");
            }
        }
    }
}

