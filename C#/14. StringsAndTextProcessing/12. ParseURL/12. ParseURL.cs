using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Write a program that parses an URL address given in the format:
// and extracts from it the [protocol], [server] and [resource] elements. 
class ParseURL
{
    static void Main(string[] args)
    {
        string urlAddress = "http://www.pss.bg/vremeto/vremeto.php";
        string protocol = "[^:]*";
        string server = @"/([^/][\w\.]*)";
        string resource = @"\b/[^/][\w.]*.+";

        Match matchProt = Regex.Match(urlAddress, protocol);
        Match matchServer = Regex.Match(urlAddress, server);
        Match matchResource = Regex.Match(urlAddress, resource);

        Console.WriteLine("[protocol] = \"{0}\"", matchProt);
        Console.WriteLine("[server] = \"{0}\"", matchServer.Groups[1]);
        Console.WriteLine("[server] = \"{0}\"", matchResource);
    }
}
