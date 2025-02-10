#include <bits/stdc++.h>
#include <algorithm>

using namespace std;

int main()
{
    vector<int> priorities = {1, 1, 9, 1, 1, 1};
    int location = 0;

    int answer = 0;

    priority_queue<int> prio;
    queue<int> proc;

    for (int i = 0; i < priorities.size(); i++)
    {
        prio.push(priorities[i]);
        proc.push(i);
    }

    while(!proc.empty())
    {
        int id = proc.front();
        proc.pop();

        if(priorities[id] >= prio.top())
        {
            answer++;

            if(id == location)
                break;
            
            prio.pop();
        }
        else
            proc.push(id);

    }

    cout << answer << '\n';
}