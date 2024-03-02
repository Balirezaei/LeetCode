using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions.Medium
{
    public class TinyURLCodec
    {
        private Dictionary<string, string> storage;
        string TinyHostUrl;

        public TinyURLCodec(string tinyHostUrl)
        {
            storage = new Dictionary<string, string>();
            TinyHostUrl = tinyHostUrl;
        }

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {

            if (storage.ContainsKey(longUrl))
            {
                return storage[longUrl];
            }
            var firstIndexToSkip = 0;
            if (longUrl.StartsWith("https://"))
            {
                firstIndexToSkip = longUrl.IndexOf("https://") + 8;
            }
            else if (longUrl.StartsWith("http://"))
            {
                firstIndexToSkip = longUrl.IndexOf("https://") + 7;
            }

            var newlongUrl = longUrl.Substring(firstIndexToSkip, longUrl.Length - firstIndexToSkip);
            //0 to 255
            var result = new int[8];
            var byteArray = Encoding.ASCII.GetBytes(newlongUrl);
            for (int i = 0; i < newlongUrl.Length; i++)
            {

                int askiCode = byteArray[i];
                var shouldPutToArray = true;
                int j = 0;
                while (shouldPutToArray)
                {
                    if (result[j] == 0)
                    {
                        result[j] = askiCode;
                        shouldPutToArray = false;
                    }
                    else if (result.All(m => m != 0))
                    {
                        if (result[j] + askiCode > 255)
                        {
                            result[j] = (result[j] + askiCode) - 255;
                        }
                        else
                        {
                            result[j] = (result[j] + askiCode);
                        }
                        shouldPutToArray = false;
                    }
                    else
                    {
                        j++;
                        if (j >= result.Length)
                        {
                            j = 0;
                        }
                    }
                }
            }

            var isNotRepeated = true;

            var correspondstring = string.Join("", result.Select(m => Convert.ToChar(m)));
            var tempString = correspondstring;
            var k = 0;
            var n = 0;
            while (storage.Any(m => m.Value == tempString))
            {
                if ((result[k] + n + 1) < 255)
                {
                    result[k] = (result[k] + n + 1);
                }
                else if ((result[k] + (n - 1)) > 0)
                {
                    result[k] = (result[k] + (n - 1));
                }
                else
                {
                    k++;
                    n++;
                    if (k >= result.Length)
                    {
                        k = 0;
                    }
                    continue;
                }
                tempString = string.Join("", result.Select(m => Convert.ToChar(m)));
                k++;
                n++;
                if (k >= result.Length)
                {
                    k = 0;
                }
            }
            var tinyUrl = TinyHostUrl + tempString;
            storage.Add(longUrl, tinyUrl);

            return tinyUrl;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            if (storage.Any(m => m.Value == shortUrl))
            {
                return storage.FirstOrDefault(m=>m.Value==shortUrl).Key;
            }
            return null;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(url));
}
