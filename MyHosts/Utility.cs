using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyHosts
{
  public class Utility
  {
    public static string ReadTextFile(string filePath)
    {
      string rawText;

      // Use UTF-8 encoding to read file content
      using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
      {
        using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
        {
          rawText = reader.ReadToEnd();
        }
      }

      return rawText.Replace("\n", Environment.NewLine);
    }

    public static void WriteTextFileWithSharedMode(string filePath, string content)
    {
      // Use UTF-8 encoding to convert string to byte array
      byte[] bytes = Encoding.UTF8.GetBytes(content);

      // Open file and write in shared mode
      using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
      {
        fileStream.Write(bytes, 0, bytes.Length);
      }
    }

    public static bool ValidateIPv4(string ipAddress)
    {
      // Regular expression for IPv4 address
      string ipv4Pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

      // Use regular expression for matching
      return Regex.IsMatch(ipAddress, ipv4Pattern);
    }

    public static bool ValidateIPv6(string ipAddress)
    {
      // Regular expression for IPv6 address
      string ipv6Pattern = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";

      // Use regular expression for matching
      return Regex.IsMatch(ipAddress, ipv6Pattern);
    }

    public static bool ValidateDomain(string domain)
    {
      // Regular expression for domain name
      string domainPattern = @"^([a-zA-Z0-9][a-zA-Z0-9-]{1,61}[a-zA-Z0-9]\.)+[a-zA-Z]{2,}$";

      // Use regular expression for matching
      return Regex.IsMatch(domain, domainPattern);
    }

    public const string HTTP_Scheme = "http://";
    public const string HTTPS_Scheme = "https://";

    public static string ParseURI(string url)
    {
      if (url.StartsWith(HTTP_Scheme))
      {

      }
      else if (url.StartsWith(HTTPS_Scheme))
      {

      }
      else
      {
        url = HTTP_Scheme + url;
      }

      return url;
    }

    public static string GetHost(string url)
    {
      try
      {
        url = ParseURI(url);

        return new Uri(url).Host;
      }
      catch (Exception)
      {
        return null;
      }
    }

    public static IPAddress[] GetIPList(string hostNameOrAddress)
    {
      try
      {
        IPHostEntry hostEntry = Dns.GetHostEntry(hostNameOrAddress);

        return hostEntry.AddressList;
      }
      catch (Exception)
      {
        return null;
      }
    }

    public static void ParseUrl2IP(string url, out string ip)
    {
      var host = GetHost(url);

      var addressList = GetIPList(host);

      ip = addressList?.Length > 0 ? addressList[0].ToString() : null;
    }

    public static bool TryValidateIP(string input, out string ip)
    {
      ip = input;

      if (ValidateIPv4(input) == false && ValidateIPv6(input) == false)
      {
        ParseUrl2IP(input, out ip);
      }

      return string.IsNullOrEmpty(ip) == false && (ValidateIPv4(ip) || ValidateIPv6(ip));
    }

    public static bool TryValidateDomain(string input, out string domain)
    {
      domain = input;

      if (ValidateDomain(input) == false)
      {
        domain = GetHost(input);
      }

      return string.IsNullOrEmpty(domain) == false && ValidateDomain(domain);
    }
  }
}