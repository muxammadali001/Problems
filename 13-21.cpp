#include <iostream>
#include <iomanip>

using namespace std;

int main13()
 {
  double eni, boyi;
  cin >> eni >> boyi;
  
  double area = eni*boyi;
  
  cout << "Area is " <<setprecision(2) << fixed << area  <<"."<< endl;
  
  
 return 0;

}
int main()
{
  float son;

  cin >> son;

  cout << setprecision(0) << fixed << son << endl;

  return 0;
}