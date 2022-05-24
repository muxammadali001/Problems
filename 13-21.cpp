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
int main14()
{
  float son;

  cin >> son;

  cout << setprecision(0) << fixed << son << endl;

  return 0;
}
int main()
 {
  char harf;
  cin >> harf;
  
   cout << (char)(harf-32) << endl;
  
  
return 0;

  }