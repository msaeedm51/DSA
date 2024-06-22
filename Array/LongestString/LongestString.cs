class Program
    {
        static void Main(string[] args)
        {
            string[] sarray = { "anagram", "nagaram","ghggbnbjgs" };
            Console.WriteLine(FindLongestString(sarray));
           
        }

        public static string FindLongestString(string[] stringsData)
        {
            var lstring = string.Empty;
            foreach (var s in stringsData)
            {
                if (s.Length > lstring.Length)
                {
                    lstring = s;
                }
            }

            return lstring;
        }
        

    }