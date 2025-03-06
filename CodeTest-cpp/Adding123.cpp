#include <bits/stdc++.h>
#include <iostream>

using namespace std;

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);
    cout.tie(0);

    int arr[12];
    int n;

    arr[1] = 1;
    arr[2] = 2;
    arr[3] = 4;

    for(int i = 4; i <= 11; i++)
        arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];

    cin >> n;

    for (int i = 0; i < n; i++)
    {
        int m;
        cin >> m;
        cout << arr[m] << endl;
    }
    return 0;
}