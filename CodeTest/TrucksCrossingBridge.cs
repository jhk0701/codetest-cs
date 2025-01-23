using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class TrucksCrossingBridge
    {
        public int CrossBridge(int bridgeLength, int weight, ref int[] truckWeights) 
        {
            int time = 0, weightInBridge = 0;
            Queue<int> ready = new(), crossing = new(), passed = new();
            int[] processed = new int[truckWeights.Length];
            
            for (int i = 0; i < truckWeights.Length; i++)
            {
                ready.Enqueue(i);
                processed[i] = 0;
            }

            while (passed.Count < truckWeights.Length) 
            {
                time += 1;

                // 지나가는 트럭 처리
                int crossingCnt = crossing.Count;
                for (int j = 0; j < crossingCnt; j++) 
                {
                    int idx = crossing.Dequeue();
                    processed[idx]++;

                    if (processed[idx] < bridgeLength)
                        crossing.Enqueue(idx);
                    else
                    {
                        weightInBridge -= truckWeights[idx]; // 처리 종료
                        passed.Enqueue(idx);
                    }
                }

                // 빈 자리에 무게 조건 확인해서 트럭 추가
                if (ready.Count > 0 &&
                    crossing.Count < bridgeLength && 
                    weightInBridge + truckWeights[ready.Peek()] <= weight) 
                {
                    int idx = ready.Dequeue();
                    weightInBridge += truckWeights[idx];

                    crossing.Enqueue(idx);
                }
            }

            return time;
        }
    
    }
}
