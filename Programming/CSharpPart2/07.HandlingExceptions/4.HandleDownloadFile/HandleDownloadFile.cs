/*Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
 * and stores it the current directory. 
 * Find in Google how to download files in C#. 
 * Be sure to catch all exceptions and to free any used resources in the finally block.*/

using System;
using System.Collections.Generic;
using System.Net;
using System.IO;

class HandleDownloadFile
{

    static void Main()
    {
        WebClient client = new WebClient();

        try
        {
            string webLink = "http://www.devbg.org/img/Logo-BASD.jpg";
            string dirPath = @"..\..\a.jpg";

            client.DownloadFile(webLink, dirPath);

            Console.WriteLine("File was downloaded successfully!");
        }
        catch (WebException exc)
        {
            Console.WriteLine("Network Error: " + exc.Message +
                              "\nStatus code: " + exc.Status);
        }
        catch (ProtocolViolationException exc)
        {
            Console.WriteLine("Protocol Error: " + exc.Message);
        }
        catch (UriFormatException exc)
        {
            Console.WriteLine("URI Format Error: " + exc.Message);
        }
        catch (NotSupportedException exc)
        {
            Console.WriteLine("Unknown Protocol: " + exc.Message);
        }
        catch (IOException exc)
        {
            Console.WriteLine("I/O Error: " + exc.Message);
        }
        finally
        {
            client.Dispose();
        }

    }
}