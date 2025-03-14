#include <iostream>
#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);
    cout.tie(0);

    int stair[300];
    int arr[300][2];

    int n;
    cin >> n;

    for(int i = 0; i < n; i++) 
        cin >> stair[i];
    
    if(n == 1)
        cout << stair[n - 1] << endl;
    else
    {
        arr[0][0] = stair[0];
        arr[0][1] = 0;
        
        arr[1][0] = stair[1];
        arr[1][1] = stair[1] + stair[0];

        for(int i = 2; i < n; i++)
        {
            arr[i][0] = max(arr[i-2][0], arr[i-2][1]) + stair[i];
            arr[i][1] = arr[i-1][1] + stair[i];
        }

        cout << max(arr[n - 1][0], arr[n - 1][1]) << endl;
    }

    return 0;
}