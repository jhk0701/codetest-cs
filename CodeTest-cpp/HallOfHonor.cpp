#include <bits/stdc++.h>
#include <algorithm>

using namespace std;

int main()
{
    int k = 3;
    vector<int> score = {10, 100, 20, 150, 1, 100, 200};

    vector<int> answer;
    priority_queue<int, vector<int>, greater<int>> pq;

    for(int i = 0; i < score.size(); i++)
    {
        pq.push(score[i]);
        
        if(pq.size() > k)
            pq.pop();

        int t = pq.top();
        answer.push_back(t);
    }
}