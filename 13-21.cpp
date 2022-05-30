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
int main15()
 {
  char harf;
  cin >> harf;
  
   cout << (char)(harf-32) << endl;
  
  
 return 0;
}
int main16()
 {
 char harf;
 cin >> harf;
  
 cout << (char)(harf+32) << endl;
  
 return 0;

}
int main17()
{
  int son;

  cin >> son;

  cout << son / 10000 << "!" ; 
  cout << son / 1000 % 10 << "!"; 
  cout << son / 100 % 10 << "!"; 
  cout << son / 10 % 10 << "!"; 
  cout << son % 10; 

  return 0;
}
int main18()
{
  int sekund;
  cin >> sekund;
  
  int soat = sekund / 3600;
  int minut = sekund % 3600 / 60;
  sekund = sekund % 60;
  
  cout << setw(2) << setfill('0') << soat << ":";
  cout << setw(2) << setfill('0') << minut << ":";
  cout << setw(2) << setfill('0') <<sekund;
  
  return 0;
}
int main19()
{
 int son;
  
 cin >> son;
  
 cout << son/ 100 % 10 << endl;
  
 return 0;

}
int main20() 
{
  int N;
  cin >> N;

  int target = N / 100 % 10;

  cout << (N = target < 5 ? N / 1000 * 1000 :(N / 1000 + 1) * 1000) << endl;
  
  return 0;
}
int main21()
{
  float length;
    float PI = 3.14;
  
    cin >> length;
    
    float radius = length / (2 * PI);
    float area = PI * radius * radius;
  
    cout << setprecision(0) << fixed << area << endl;
  
  return 0;
}
int main22()
{
  int N;
  
    cin >> N;
  
  if(N >=20 && N <=30)
    {
      cout << 1 << endl;
    }
    else 
    {
      cout << 0 << endl;
    }
 
  return 0;
}
int main23()
{
  char harf;
  
    cin >> harf;
  
    if(harf >='a' && harf<='z')  
    {
    cout << 1 << endl;
    
    }
    else if(harf>='A' && harf<='Z')
  {
    cout << 1 << endl;
  }
  else 
  {
    cout << 0 << endl;
  }
  
    
  
  return 0;
  }
  int main24()
{
  int N;

    cin >> N;
  
  if(N % 2  == 0)
  {
    cout << "even" << endl;
  }
  else 
  {
    cout  << "odd" << endl;
  }

  return 0;
}
int main()
{
  int N, M;
  cin >> N >> M;
  if(N > M)
  {
    cout << N << endl;
  }
  else
  {
    cout << M << endl;
  }
  
  return 0;
}