public class SlidingWindow
{
        public string MakeFancyString(string s) {
        Dictionary<char, int> charMap = new Dictionary<char, int>();

        if (s.Length < 3)
        {
            return s;
        }

        //build the window
        int lptr = 0;
        int rptr = 0;
        while (rptr < 2)
        {
            if (charMap.ContainsKey(s[rptr]))
            {
                charMap[s[rptr]]++;
            }
            else
            {
                charMap.Add(s[rptr], 1);
            }

            rptr++;
        }

        //slide it
        while (rptr < s.Length)
        {
            if (charMap.ContainsKey(s[rptr]))
            {
                if (charMap[s[rptr]] >= 2)
                {
                    s = s.Remove(rptr, 1);
                    continue;
                }

                charMap[s[rptr]]++;
            }
            else 
            {
                charMap.Add(s[rptr], 1);
            }

            rptr++;

            charMap[s[lptr]]--;

            lptr++;
        }

        return s;
    }
}