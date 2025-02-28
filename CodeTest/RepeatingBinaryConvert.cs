using System.Text;

namespace Test
{
    public class RepeatingBinaryConvert
    {
        public int[] Sol(string s) 
        {
            string target = "1";
            int removed = 0;
            int cnt = 0;

            while (s != target)
            {
                cnt++;
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '0')
                        removed++;
                    else
                        sb.Append(s[i]);
                }

                int len = sb.ToString().Length;

                sb = new StringBuilder();
                while (len >= 2)
                {
                    sb.Append(len % 2);

                    len /= 2;
                }

                sb.Append(len);
                s = new string(sb.ToString().Reverse().ToArray());
            }

            return new int[] { cnt, removed };
        }
    
    }
}
