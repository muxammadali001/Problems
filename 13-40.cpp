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
int main25()
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
int main26()
{
  int a, b;
  cin >> a >> b;
  
  if(a > b)
  {
  	cout << a / b << endl;
    cout << a % b;
  }
  else
  {
    cout << b / a << endl;
    cout << b % a;
  }
	return 0;
}
int main27()
{
    int a, b, c;
    cin >> a >> b;
  
  if(a == 0)
  {
   a = 24;
  }
  c = (a * 60) + (b - 45);
  cout << c / 60 << " " << c % 60 << endl;

   
    return 0;
}
int main28()
{
  int N ;
  cin >> N;
  if( N <= 0)
  {
    cout <<"ichkarida o'yna"<<endl;
  }
  else if( N < 40)
  {
  cout <<"tashqarida o'yna" <<endl;
  }
  else
  {
   cout <<"ichkarida o'yna"<<endl;     
  }
 
return 0;
}
int main29()
{
  int N, M;
  cin >> N >> M;
  if(N * N == M)
  {
    cout <<N << "*" << N<< "=" << M  << endl;
  }
  else if(M * M == N)
  {
    cout << M  << "*" << M  << "=" << N << endl;
  }
  else 
  {
    cout << "none"  << endl;
  }
  


  return 0;
}
int main31()
{
  int a, b, c;
  cin >> a >> b >>c;
  if(a > b && a > c)
  {
  	cout << a << endl;
  }
  else if(b > a && b > c)
  {
  	cout << b << endl;
  }
   else
  {
  	cout << c << endl;
  }
 

  return 0;
}
int main32()
{
  int n;
  cin >> n;
  
  if(n % 4 != 0)
  {
    cout << "0" << endl;
  }
  
  else if ( n % 100 == 0 && n % 400 != 0)
  {
  	cout << "0" << endl;
  } 
  
  else
  {
  	cout << "1" << endl;
  }  
  
  return 0;
}
int main33()
{
  int N, M;
  
  cin >> N >> M;
  
  if(N == M)
  {
    cout << "YORVORDIZ" << endl;
  }
  else if(N > M)
  {
    cout << "TEPAGA" << endl;
  }
  else
  {
    cout << "PASTGA" << endl;
  }
  
  cin >> M;
  
  if(M == N)
  {
    cout << "YORVORDIZ" << endl;
  }
  else if(M > N)
  {
    cout << "PASTGA" << endl;
  }
  else
  {
    cout << "TEPAGA" << endl;
  }
  
  return 0;
}
int main34()
{
 char harf;
  cin >> harf;
  
  if(harf >= 'A' && harf <='Z')
  {
  cout << (char)(harf+32) << endl;
  }
  else if (harf >= 'a' && harf <='b')
  {
  cout << (char)(harf-32) << endl;
  }
  else
  {
  cout << "none" << endl;
  }
  return 0;
}
int main35()
{
  int a, b;
  cin >> a;
  
  char N;
  cin >> N;
  cin >> b;
  
  if (N == 43)
  {
  	cout << a + b << endl;
  }  
  else if ( N == 45)
  {
  	cout << a - b << endl;
  }  
return 0;
}
int main37()
{
  int qaytim;
  int sum;
  int orderNum;
  
  cin >> orderNum >> sum;
  
  switch(orderNum)
  {
    case 1:
      cout << "Americano"<< endl;
      qaytim = sum - 500;
      break;
    case 2:
      cout <<"Caffe Latte"<< endl;
      qaytim = sum - 400;
      break;
    case 3:
      cout <<"Lemon Tea"<< endl;
      qaytim = sum - 300;
      break;
  }
  cout << qaytim / 500 << " " <<qaytim % 500 / 100 << endl;
  
return 0;
}
int main()//pifagor
{
    int a,b,c;
    cin >> a >> b >> c;
    
    if(a * a + b * b ==c * c)
    {
        cout << "true" << endl;
    }
    
    else if(a * a + c * c == b * b)
    {
        cout << "true" << endl;
    }
    
    else if(b * b + c * c == a * a)
    {
        cout << "true" << endl;
    }
    else 
    {
        cout << "false" << endl;
    }
    
    return 0;
  
}