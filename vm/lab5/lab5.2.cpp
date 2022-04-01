#include<iostream>
#include<cmath>
#include<locale.h>
#include<iomanip>
#include<vector>
#include<fstream>
/// ITERACIIIIII
using namespace std;
int k = 0;
double *iteracii(double **a, int n, double eps) {

  double *prevx = new double[n];
  for(int i = 0; i<n; i++)
    prevx[i] = 0.0;
  k = 0;
  while(true) {
    k++;
    double *currentx = new double[n];
    for(int i = 0; i<n; i++) {
      currentx[i] = a[i][n];

      for(int j = 0; j<n; j++)
        if(i != j)
          currentx[i] -= a[i][j] * prevx[j];

      currentx[i] /= a[i][i];
    }

    double error = 0.0;
    for(int i = 0; i<n; i++)
      error += abs(currentx[i]-prevx[i]);

    if(error < eps)
      break;

    prevx = currentx;
  }

  return prevx;
}

int main() {
  setlocale(LC_ALL, "rus");

  ifstream fin("input.txt");
  int n;
  fin>>n;
  double **a, **a1, *x = new double[n];
  a = new double*[n];
  a1 = new double*[n];
  for(int i = 0; i<n; i++) {
    a[i] = new double[n+1];
    a1[i] = new double[n+1];
    for(int j = 0; j<n+1; j++){
      fin>>a[i][j];
      a1[i][j] = a[i][j];
    }
  }
  fin.close();
  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n; j++)
      cout<<setw(2)<<a[i][j]<<"x"<<i+1<<" + ";
    cout<<" = "<<setw(2)<<a[i][n]<<endl;
  }

  double eps;
  cout<<"Введите точность: ";
  cin>>eps;

  x = iteracii(a1,n,eps);

  for(int i = 0; i<n; i++)
    cout<<"x"<<i+1<<" = "<<x[i]<<endl;

  cout<<"Проверка"<<endl;
  cout<<"   результат |  дано"<<endl;
  for(int i = 0; i<n; i++) {
    double s = 0;
    for(int j = 0; j<n; j++){
      s += x[j] * a[i][j];
    }
    cout<<setw(9)<<s<<" | "<<setw(5)<<a[i][n]<<endl;
  }

  cout<<"Количество итераций: "<<k<<endl;

  return 0;
}
