#include<iostream>
#include<cmath>
#include<locale.h>
#include<iomanip>
#include<vector>
#include<fstream>
///GAUSSSSS
using namespace std;

double *gauss(double **a, double *y, int n) {
  double *x, max;
  int k, index;
  double eps = 0.001;
  x = new double[n];
  k = 0;
  while(k<n) {
    ///поиск строки с максимальным a[i][k]
    max = abs(a[k][k]);
    index = k;
    for(int i  = k+1; i<n; i++) {
      if(abs(a[i][k])>max) {
        max = abs(a[i][k]);
        index = i;
      }
    }
    /// перестановка строк
    if(max<eps) {
      ///нет ненулевых диагональных элементов
      cout << "Решение получить невозможно из-за нулевого столбца ";
      cout << index << " матрицы A" << endl;
    }
    double *temp = a[k];
    a[k] = a[index];
    a[index] = temp;
    double temp1 = y[k];
    y[k] = y[index];
    y[index] = temp1;
    /// нормализация уравнений
    for(int i = k; i<n; i++) {
      double temp = a[i][k];
      if(abs(temp)<eps) continue;
      for(int j = 0; j<n; j++)
        a[i][j] /= temp;
      y[i] /= temp;
      if(i == k) continue;
      for(int j = 0; j<n; j++)
        a[i][j] -=a[k][j];
      y[i] -= y[k];
    }
    k++;
  }
  /// обратная подстановка
  for(k = n -1; k>=0; k--) {
    x[k] = y[k];
    for(int i = 0; i<k; i++)
      y[i] -= a[i][k]*x[k];
  }

  return x;
}

int main() {
  setlocale(LC_ALL, "rus");

  ifstream fin("input.txt");
  int n;
  fin>>n;
  double **a, **a1, *x, *y, *y1;
  a = new double*[n];
  y = new double[n];
  a1 = new double*[n];
  y1 = new double[n];
  for(int i = 0; i<n; i++) {
    a[i] = new double[n];
    a1[i] = new double[n];
    for(int j = 0; j<n; j++){
      fin>>a[i][j];
      a1[i][j] = a[i][j];
    }
    fin>>y[i];
    y1[i] = y[i];
  }
  fin.close();
  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n; j++)
      cout<<setw(2)<<a[i][j]<<"x"<<i+1<<" + ";
    cout<<" = "<<setw(2)<<y[i]<<endl;

  }

  x = gauss(a1,y1,n);

  for(int i = 0; i<n; i++)
    cout<<"x"<<i+1<<" = "<<x[i]<<endl;

  cout<<"Проверка"<<endl;
  cout<<"результат | дано"<<endl;
  for(int i = 0; i<n; i++) {
    double s = 0;
    for(int j = 0; j<n; j++){
      s += x[j] * a[i][j];
    }
    cout<<setw(9)<<s<<" | "<<setw(5)<<y[i]<<endl;
  }

  return 0;
}
