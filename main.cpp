//#include <bits/stdc++.h>
#include <iostream>

using namespace std;

int getOccurence(int n, int d)
{
	int result = 0; // Initialize result
	int itr = d;
	while (itr <= n)
	{
		if (itr%10 == d)
			result++;
		if (itr != 0 && itr/10 == d)
		{
			result++;
			itr++;
		}
		else if (itr/10 == d-1)
			itr = itr + (10 - d);
		else
			itr = itr+10;
	}
	return result;
}

int main(void)
{
	int a, b;
	cin >> a >> b;

	for(int i = 0; i < 10; i++)
	{
		
	}
	cout << getOccurence(a, b);
	return 0;
}