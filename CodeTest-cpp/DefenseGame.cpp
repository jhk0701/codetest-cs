#include <string>
#include <vector>
#include <queue>
#include <iostream>

using namespace std;

int main() 
{
    int n = 7;
    int k = 3;
    vector<int> enemy = {4, 2, 4, 5, 3, 3, 1};

    int answer = 0;    

    priority_queue<int, vector<int>, greater<int>> pq;

    for (int i = 0; i < enemy.size(); i++)
    {
        if(pq.size() < k)
        {
            pq.push(enemy[i]);
            answer++;
            continue;
        }

        if(enemy[i] > pq.top())
        {
            n -= pq.top();
            cout << pq.top() << '\n';
            pq.pop();
            pq.push(enemy[i]);

            if(n >= 0)
                answer++;
            else
                break;
        }
        else
        {
            n -= enemy[i];

            if (n>=0)
                answer++;
            else
                break;
        }

    }
    
    cout << answer << '\n';
    
    return answer;
}