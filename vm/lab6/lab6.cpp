#include<iostream>
#include<cmath>
#include<locale.h>
#include<iomanip>
#include<vector>
#include<fstream>

using namespace std;

double f(double x, double y) {
  return  y;
}

int main() {
  setlocale(LC_ALL, "rus");

  int n = 20;
	cout<<"¬ведите a: ";
	double a; cin>>a;
	cout<<"¬ведите b: ";
	double b; cin>>b;

	double h = (b-a)/n;

	double *x = new double[n]; /// значени€ x
	double *y = new double[n]; /// точные y
	double *y1 = new double[n]; /// грубо приближЄнные y

  cout<<"¬ведите y0: ";
	cin>>y[0]; /// задаЄм начальное условие задачи
	x[0] = a;

  cout << fixed;
	cout.precision(3);

	for (int i = 1; i <= 3; i++) {
		double k1 = h * f(x[i - 1], y[i - 1]);
		double k2 = h * f(x[i - 1] + h / 2, y[i - 1] + k1 / 2);
		double k3 = h * f(x[i - 1] + h / 2, y[i - 1] + k2 / 2);
    double k4 = h * f(x[i - 1] + h, y[i - 1] + k3);
		x[i] = x[i - 1] + h;
		y[i] = y[i - 1] + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
	}

	for(int j = 4; j<=n; j++) {
      x[j] = x[j-1]+h;
      double y1 = y[j-1] + (h/24)*(55*f(x[j-1], y[j-1]) - 59*f(x[j-2], y[j-2]) + 37*f(x[j-3], y[j-3]) - 9*f(x[j-4], y[j-4]));
      y[j] = y[j-1] + (h/24)*(9*f(x[j], y1) + 19*f(x[j-1], y[j-1]) - 5*f(x[j-2], y[j-2]) + f(x[j-3], y[j-3]));
	}

	ofstream fout,f1;
	fout.open("result.csv");
	for (int i = 0; i <= n; i++) {
		cout << "X[" << i << "]= " << x[i] << "\t" << "Y[" << i << "]= " << y[i] << "\n";
		fout<<x[i]<<";"<<y[i]<<endl;
	}
  fout.close();
  return 0;
}
