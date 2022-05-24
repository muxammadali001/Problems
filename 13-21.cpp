#include <iostream>
#include <iomanip>

using namespace std;

int main()
 {
  double eni, boyi;
  cin >> eni >> boyi;
  
  double area = eni*boyi;
  
  cout << "Area is " <<setprecision(2) << fixed << area  <<"."<< endl;
  
  
return 0;

  }