using System;

namespace TheMosh.Dcp._092319
{
    public class Finder
    {
        public static string FindFirstRecurring(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return null;
            }

            string firstRecurring = null;
            int firstRecurringAt = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if(firstRecurringAt > -1 && firstRecurringAt <= i)
                {
                    break;
                }

                string sCheck = s.Substring(i, 1);

                for (int j = i + 1; j < s.Length; j++)
                {
                    if(firstRecurringAt > -1 && j >= firstRecurringAt)
                    {
                        continue;
                    }

                    string jVal = s.Substring(j, 1);
                    if (sCheck == jVal)
                    {
                        if (firstRecurringAt == -1 || firstRecurringAt > j)
                        {
                            firstRecurringAt = j;
                            firstRecurring = sCheck;
                            break;
                        }
                    }
                }
            }

            return firstRecurring;
        }
    }
}
