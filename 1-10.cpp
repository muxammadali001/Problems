#include <iostream>
#include <iomanip>

using namespace std;

int main1()
{
  cout <<"222222"<< endl;
  cout <<"2    2"<< endl;
  cout <<"2    2"<< endl;
  cout <<"222222"<< endl;
 return 0;
 }
 int main2()
 {
   cout << "  A" << endl;
   cout << " A A" << endl;
   cout << "AAAAA" << endl;
  
  return 0;
 }
 int main3()
{
  cout <<"\\    /\\"<< endl;
  cout <<" )  ( ')"<< endl;
  cout <<"(  /  )"<< endl;
  cout << " \\(__)|"<< endl;
  return 0;
}
int main4()
{
  
  cout << "|\\_/|" << endl;
  cout << "|qp| /}" << endl;
  cout << "( 0 )\"\"\"\\" << endl;
  cout << "|\"^\"` |" << endl;
  cout << "||_/=\\\\__|" << endl;  
 return 0;
}
int main5()
{
  int oy, kun;
  cin >> oy >> kun;
  
  cout << "Birthday is " << setw(2) << setfill('0') << oy << "-" << setw(2) << setfill('0') << kun << "." << endl;
  return 0;
}
int main6()
{
  int n;
  
  cin >> n;
  
  cout << n << n << n << n << n << n <<endl;
  cout << n <<"    "<< n <<endl;
  cout << n <<"    "<< n <<endl;
  cout << n << n << n << n << n << n <<endl;
return 0;
}
int main7()
{
  int N;
    cin >> N;
    cout << "Sun Mon Tue Wed Thu Fri Sat" << endl;
    for(int a =N; a< N+7;a++)
    {
      if(a>31)
        {
          cout << setw(3) << a% 30-1<< " ";
        }
      else
      {
        cout << setw(3) << a << " ";
      }
      
    }
  
  
  
  return 0;
 }
 int main8()
{
  int n;
  
  cin >> n;
  
  for(int sum = 1; sum < 10; sum++)
  {
  cout << n << "*" << sum << "=" << n * sum << endl;
    
  } 
return 0;
}
int main()
{
  cout << "1!=" << 1 << endl;
  cout << "2!=" << 1 * 2 << endl;
  cout << "3!=" << 1 * 2 * 3 << endl;
  cout << "4!=" << 1 * 2* 3 * 4 << endl;
  cout << "5!=" << 1 * 2* 3 * 4 * 5 << endl;
return 0;
}