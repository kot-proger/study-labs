#include<iostream>
#include<cmath>
#include<locale.h>
#include<iomanip>
#include<vector>
#include<fstream>
/// INVERSE MATRIX
using namespace std;

double *zeidel(double **a, double *y, int n) {
  double **a1 = new double*[n];
  for(int i =0; i<n; i++){
    a1[i] = new double[n+1];
    for(int j = 0; j<n; j++)
      a1[i][j] = a[i][j];
    a1[i][n] = y[i];
  }
  double eps = 0.00000001;
  double *prevx = new double[n];
  for(int i = 0; i<n; i++)
    prevx[i] = 0.0;
  while(true) {
    double *currentx = new double[n];
    for(int i = 0; i<n; i++) {
      currentx[i] = a1[i][n];

      for(int j = 0; j<n; j++)
        if(i != j)
          currentx[i] -= a1[i][j] * prevx[j];

      currentx[i] /= a1[i][i];
    }

    double error = 0.0;
    for(int i = 0; i<n; i++)
      error += fabs(currentx[i]-prevx[i]);

    if(error < eps)
      break;

    prevx = currentx;
  }

  return prevx;
}

double **invmatrix(double **a, int n) {
  double **res = new double*[n];
  for(int i = 0; i<n; i++)
    res[i] = new double[n];

  double *y = new double[n];
  double *itr;
  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n; j++)
      if(i == j)
        y[j] = 1;
      else
        y[j] = 0;

    double **a1 = a;
    itr = zeidel(a1,y,n);

    for(int k = 0; k<n; k++)
      res[k][i] = itr[k];
  }

  return res;
}

double **prodmatrix(double **a, double **b, int n) {
  double **res = new double*[n];
  for(int i = 0; i<n; i++)
    res[i] = new double[n];

  for(int i = 0; i<n; i++)
    for(int j = 0; j<n; j++) {
      res[i][j] = 0;
      for(int k = 0; k<n; k++)
        res[i][j] += a[i][k] * b[k][j];
    }

  return res;
}

int main() {
  setlocale(LC_ALL, "rus");

  ifstream fin("input1.txt");
  int n;
  fin>>n;
  double **a, **a1, **x;
  a = new double*[n];
  a1 = new double*[n];
  for(int i = 0; i<n; i++) {
    a[i] = new double[n];
    a1[i] = new double[n];
    for(int j = 0; j<n; j++){
      fin>>a[i][j];
      a1[i][j] = a[i][j];
    }
  }
  fin.close();
  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n; j++)
      cout<<setw(3)<<a[i][j];
    cout<<endl;
  }

  x = invmatrix(a1,n);

  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n; j++)
      cout<<setw(10)<<setprecision(2)<<x[i][j];
    cout<<endl;
  }

  double **c;
  c = prodmatrix(a,x,n);

  cout<<"Проверка"<<endl;

  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n; j++)
      cout<<setw(10)<<setprecision(2)<<c[i][j];
    cout<<endl;
  }

  return 0;
}
