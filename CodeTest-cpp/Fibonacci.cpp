#include <iostream>
#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);
    cout.tie(0);
    
    int n;
    cin >> n;

    queue<int> qu;
    int max = 0;
    for(int i = 0; i < n; i++)
    {
        int m;
        cin >> m;

        qu.push(m);

        if(max < m)
            max = m;
    }

    vector<vector<int>> arr = {{1,0}, {0, 1}};
    for(int i = 2; i <= max; i++)
    {
        vector<int> new_arr = {0, 0};
        new_arr[0] = arr[i-1][0] + arr[i-2][0];
        new_arr[1] = arr[i-1][1] + arr[i-2][1];
        arr.push_back(new_arr);
    }

    while(!qu.empty())
    {
        int num = qu.front();
        qu.pop();

        cout << arr[num][0] << ' ' << arr[num][1] << endl;        
    }

    return 0;
}
