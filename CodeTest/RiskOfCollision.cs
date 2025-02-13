using System.Numerics;

namespace Test
{
    public struct Vector2
    {
        public int x;
        public int y;

        public Vector2(int px, int py)
        {
            x = px;
            y = py;
        }

        public static bool operator ==(Vector2 a, Vector2 b) 
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return a.x != b.x || a.y != b.y;
        }
    }

    public class RiskOfCollision
    {
        public int Collision { get; private set; }

        public RiskOfCollision(ref int[,] points, ref int[,] routes)
        {
            Dictionary<int, int[]> robotPos = new Dictionary<int, int[]>();
            Dictionary<int, int> robotProc = new Dictionary<int, int>();

            for (int i = 0; i < routes.GetLength(0); i++)
            {
                int p = routes[i, 0] - 1;
                robotPos.Add(i, new int[] { points[p, 0], points[p, 1] });
                robotProc.Add(i, 0);
            }

            while (robotProc.Count > 0)
            {
                // 충돌 감지
                HashSet<Vector2> posSet = new HashSet<Vector2>();
                HashSet<Vector2> col = new HashSet<Vector2>();
                foreach (int key in robotProc.Keys)
                {
                    int before = posSet.Count;
                    Vector2 pos = new Vector2(robotPos[key][0], robotPos[key][1]);

                    posSet.Add(pos);

                    if (before == posSet.Count)
                        col.Add(pos);
                }

                Collision += col.Count;

                // 이동
                var keys = robotProc.Keys.ToArray();
                for (int i = 0; i < keys.Length; i++) // foreach (int key in robotProc.Keys)
                {
                    // 최종 지점 도착
                    int key = keys[i];
                    if (robotProc[key] == routes.GetLength(1) - 1)
                    {
                        // 제거 처리
                        robotProc.Remove(key);
                        continue;
                    }

                    int destIdx = routes[key, robotProc[key] + 1] - 1;
                    int x = robotPos[key][0] - points[destIdx, 0];
                    int y = robotPos[key][1] - points[destIdx, 1];

                    if (x != 0)
                        robotPos[key][0] += x > 0 ? -1 : 1;
                    else if (y != 0)
                        robotPos[key][1] += y > 0 ? -1 : 1;

                    // 도달 여부 확인
                    if (robotPos[key][0] == points[destIdx, 0] &&
                        robotPos[key][1] == points[destIdx, 1])
                        robotProc[key] += 1; // 다음 목표 갱신
                }
            }

        }

    }
}
