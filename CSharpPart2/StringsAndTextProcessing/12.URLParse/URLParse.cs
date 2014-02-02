/*Write a program that parses an URL address given in the format:
 [protocol]://[server]/[resource]
 and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php 
 * the following information should be extracted:
 [protocol] = "http"[server] = "www.devbg.org"[resource] = "/forum/index.php"*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _12.URLParse
{
    class URLParse
    {

        static void FormatURL(string url)
        {
            string protocol = url.Substring(0, url.IndexOf(":"));
            Console.WriteLine("[protocol] = {0}", protocol);
            string serverAndResource = url.Substring(url.IndexOf("://") + 3);
            string resource = serverAndResource.Substring(serverAndResource.IndexOf("/"));
            string server = serverAndResource.Substring(0, serverAndResource.IndexOf("/"));
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }

        static void Main()
        {
            string URL = "http://www.devbg.org/forum/index.php";
            FormatURL(URL);
        }
    }
}
