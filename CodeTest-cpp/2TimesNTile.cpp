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

    int div = 10007;

    int arr[n];
    arr[0] = 1;
    arr[1] = 2;

    if(n > 2)
    {
        for(int i = 2; i < n; i++)
            arr[i] = (arr[i - 1] + arr[i - 2]) % div;
    }
    
    cout << arr[n - 1] << endl;

    return 0;
}
