class Program
    {
        const string CFr = "Result.txt";
        const string CFd = "Text.txt";

        static void PrintWithoutBlankLine(string fv, string fvr)
        {
            int counter = 0;
            using (StreamReader reader = new StreamReader(fv))
            {
                using (StreamWriter fr = new StreamWriter(fvr, true))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Length != 0)
                        {
                            if (counter == 0)
                            {
                                fr.Write(line);
                            }
                            else
                            {
                                fr.Write("\n" + line);
                            }
                            counter++;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            if (File.Exists(CFr)) File.Delete(CFr);
            PrintWithoutBlankLine(CFd, CFr);
        }
    }
