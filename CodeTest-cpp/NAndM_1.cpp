#include <bits/stdc++.h>
#include <algorithm>

using namespace std;

void Search(int m, vector<bool>& is_visited, vector<int>& arr)
{
    if(arr.size() == m)
    {
        for(int i = 0; i < arr.size(); i++)
        {
            if (i > 0)
                cout << ' ';

            cout << arr[i];
        }

        cout << '\n';
        return;
    }

    for(int i = 0; i < is_visited.size(); i++)
    {
        if(is_visited[i])
            continue;
            
        arr.push_back(i + 1);
        is_visited[i] = true;

        Search(m, is_visited, arr);

        arr.pop_back();
        is_visited[i] = false;
    }
}

int main()
{
    ios::sync_with_stdio(0);
    cout.tie(0);
    cin.tie(0);

    int n, m;
    cin >> n >> m;

    vector<bool> is_visited;
    vector<int> ansArr;

    for(int i = 0; i < n; i++)
        is_visited.push_back(false);

    Search(m, is_visited, ansArr);
}

