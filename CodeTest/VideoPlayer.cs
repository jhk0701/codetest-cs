using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class VideoPlayer
    {
        TimeSpan tenSec = new TimeSpan(0, 0, 10);

        public string Process(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            TimeSpan length = TimeSpan.Parse($"00:{video_len}");
            TimeSpan curPos = TimeSpan.Parse($"00:{pos}");

            TimeSpan opStart = TimeSpan.Parse($"00:{op_start}");
            TimeSpan opEnd = TimeSpan.Parse($"00:{op_end}");

            for (int i = 0; i < commands.Length; i++) 
            {
                if (opStart <= curPos && curPos < opEnd)
                    curPos = opEnd;

                curPos += commands[i].Equals("next") ? tenSec : - tenSec;
                curPos = curPos < TimeSpan.Zero ? TimeSpan.Zero : curPos;
                curPos = curPos > length ? length : curPos;
            }

            return $"{curPos.Minutes.ToString("00")}:{curPos.Seconds.ToString("00")}";
        }
    }
}
