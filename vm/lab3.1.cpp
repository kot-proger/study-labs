#include<iostream>
#include<cmath>
#include<locale.h>
#include<iomanip>

using namespace std;

double f(double x) {
  return x*x*x;
}

int main() {
  setlocale(LC_ALL, "ru");
  int a = 10;
  double eps = 0.001;
  //cout<<"Введите точность: ";
  //cin>>eps;
  double f1;
  double f2;
  double d1 = 100;
  for(int i = 0; i<11; i++) {
    double dx = 0.1;
    double x = 1.2+0.1*i;
    do {
      f1 = (f(x+dx)-2*f(x)+f(x-dx))/(dx*dx);
      dx = dx/10;
      f2 = (f(x+dx)-2*f(x)+f(x-dx))/(dx*dx);
      if(fabs(f1-f2)>d1) {
        cout<<"Заданная точность не может быть достигнута, наилучший результат при х = "<<x<<": "<<f1<<endl;
        break;
      }
    } while(fabs(f1-f2)>=eps);
    cout<<"x = "<<setw(3)<<x<<" "<<"F``(x) = "<<f1<<endl;
  }

  return 0;
}
