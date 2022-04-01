#include <stdio.h>
#include <time.h>

void printMatrix(int **a, int n){
  for(int i = 0; i<n; i++){
    for(int j = 0; j<n; j++)
      printf("%4d", a[i][j]);
    printf("\n");
  }
  printf("\n");
}

int main(){

  const int n = 5;
  int **z = (int**)calloc(n, sizeof(int*));

  srand(time(NULL));
  for(int i = 0; i<n; i++){
    z[i] = (int*)calloc(n, sizeof(int));
    for(int j = 0; j<n; j++)
      z[i][j] = rand()%3;
  }

 printMatrix(z, n);

  for(int i = 0; i<n; i++){
    if(z[i][i] == 0){
      int sum = 0;
      for(int j = 0; j<n; j++)
        sum += z[i][j];
      z[i][i] = sum;
    }
  }

  printMatrix(z, n);

  return 0;
}
