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
    
    int arr[n];
    vector<vector<int>> d;

    for(int i = 0; i < n; i++)
        cin >> arr[i];

    d.push_back({arr[0], 0, 1});

    for(int i = 1; i <= n - 1; i++)
    {
        int val = d[i - 1][0];
        int prevIdx = d[i - 1][1];
        int cnt = d[i - 1][2];
        
        
    }

    return 0;
}