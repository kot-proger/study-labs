#include<iostream>
#include<cmath>
#include<locale.h>
#include<iomanip>

using namespace std;

double f(double x) {
  return x*x;
}

double lrect(int n, double a, double b) {
  double s = 0;
  double h = (b-a)/n;
  for(double i = a; i<b; i+= h){
    s += f(i);
  }
   return s*h;
}

int main() {
  setlocale(LC_ALL, "rus");
  double eps = 0.0001;
  //cout<<"Введите точность: ";
  //cin>>eps;
  int n = 10, a = 0, b = 3;
  double i2 = lrect(n, a ,b), i1;
  while(true) {
    i1 = i2;
    i2 = lrect(2*n, a ,b);
    if(fabs(i1-i2)/2<eps) break;
    else n *= 2;
  }
  cout<<"интеграл от х в пределах от 0 до 3 равен "<<i1;
  return 0;
}
