#include<iostream>
#include<cmath>
#include<locale.h>
#include<iomanip>
#include<vector>

using namespace std;

double f(double x) {
  return sqrt(x);
}

int main() {
  setlocale(LC_ALL, "rus");

  cout<<"Enter a: ";
  double a; cin>>a;

  cout<<"Enter b: ";
  double b; cin>>b;

  cout<<"Enter n: ";
  double n; cin>>n;

  double h = (b-a)/n;

  vector<double> x;
  for(double i = a; i<=b; i+=h)
    x.push_back(i);

  vector<double> y;
  for(auto it = x.begin(); it<x.end(); it++)
    y.push_back(f(*it));

  cout<<setw(10)<<"x:"<<" y"<<endl;
  for(int i = 0; i<x.size(); i++)
    cout<<setw(10)<<x.at(i)<<": "<<y.at(i)<<endl;

  cout<<"Enter z:";
  double z; cin>>z;

  double q = (z - x[0])/h;
  q = floor(q);

  vector<double> bl;
  bl.push_back(0);
  vector<double> cl;

  for(int i = 1; i<=n; i++)
    bl.push_back(y[i-1]-bl.at(i-1));

  for(int i = 0; i<n; i++)
    cl.push_back((bl.at(i+1)-bl.at(i))/2*h);

  double s = y[q]+bl.at(q)*(z-x[q])+cl.at(q)*(z-x[q])*(z-x[q]);

  cout<<"Значение по интерполяции: "<<s<<endl;
  cout<<"Значение по функции: "<<f(z)<<endl;
  cout<<"Погрешность: "<< abs(s-f(z));

  return 0;
}
