#include <iostream>
#include <iomanip>

using namespace std;

int main() {

  int n = 3;
  cout<<"Enter n: ";
  cin>>n;
  while(n/2 == 0) {
    cout<<"Enter n: ";
    cin>>n;
  }


  int a[n][n];
  int k = 1, napr = 0;

  for(int i = 0; i<n; i++)
    for(int j = 0; j<n; j++)
      a[i][j] = 0;

  int i = n/2, j = n/2;
  while(k<=(n*n/4 + n/2+1)) {

    while ((i>0) && (j<n-1) && !(a[i-1][j+1]>0)) {
      if(k>=(n*n/4 + n/2 + 1)) break;
      a[i--][j++] = k++;
    }

    while((i<n-1) && !(a[i+1][j]>0)) {
      if(k>=(n*n/4 + n/2 + 1)) break;
      a[i++][j] = k++;
    }

    while((i>0) && (j>0) && !(a[i-1][j-1]>0)) {
      if(k>=(n*n/4 + n/2 + 1)) break;
      a[i--][j--] = k++;
    }
    a[i--][j] = k++;

  }

  for(int i = 0; i<n; i++) {
    for(int j = 0; j<n; j++)
      cout<<setw(3)<<a[i][j];
    cout<<endl;
  }


  return 0;
}
