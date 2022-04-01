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

  vector<vector<double>> dy;
  dy.resize(n);
  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n-i-1; j++)
      if(i == 0) dy.at(i).push_back(y[j+1]-y[j]);
      else dy.at(i).push_back(dy.at(i-1).at(j+1)-dy.at(i-1).at(j+1));
  }

  double fact = 1, p = q, yi = y[0];
  for(int i = 1; i<n; i++) {
      yi += (p*dy.at(i-1).at(0))/fact;
      fact *= i+1;
      p *= q-i;
  }

  cout<<yi<<endl<<"Погрешность: "<<abs(yi-f(z));


  return 0;
}
