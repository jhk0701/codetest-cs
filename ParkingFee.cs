using System.Collections.Generic;
using System.Linq;

namespace CodeTest
{
    //Programmers-92341
    // https://school.programmers.co.kr/learn/courses/30/lessons/92341
    class ParkingFee
    {
        public int[] Sol(int[] fees, string[] records)
        {
            HashSet<string> cars = new HashSet<string>();
            Dictionary<string, Stack<DateTime>> carEnterance = new Dictionary<string, Stack<DateTime>>();
            Dictionary<string, double> carParkingTime = new Dictionary<string, double>();

            foreach (string record in records)
            {
                // 0 : 시간, 1 : 번호, 2 : 입출차 여부
                string[] data = record.Split(' ');

                DateTime time = Convert.ToDateTime(data[0]);
                string carNum = data[1];

                if (!cars.Contains(carNum))
                {
                    cars.Add(carNum);
                    
                    carEnterance.Add(carNum, new Stack<DateTime>());
                    carEnterance[carNum].Push(time);

                    carParkingTime.Add(carNum, 0);
                }
                else
                {
                    if(data[2] == "OUT")
                        carParkingTime[carNum] += (time - carEnterance[carNum].Peek()).TotalMinutes;

                    carEnterance[carNum].Push(time);
                }
            }

            DateTime forcedOut = Convert.ToDateTime("23:59");
            List<int> ans = new List<int>();
            string[] carNums = cars.OrderBy(n=>n).ToArray();

            foreach (string car in carNums)
            {
                if (carEnterance[car].Count % 2 == 1)
                    carParkingTime[car] += (forcedOut - carEnterance[car].Peek()).TotalMinutes;

                int fee = fees[1];
                carParkingTime[car] -= fees[0];

                if (carParkingTime[car] >= 0)
                    fee += (int)(carParkingTime[car] / fees[2] + (carParkingTime[car] % fees[2] > 0 ? 1 : 0)) * fees[3];

                ans.Add(fee);
            }

            return ans.ToArray();
        }
    }
}
