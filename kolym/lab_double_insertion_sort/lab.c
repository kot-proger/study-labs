#include <stdio.h>
#include <time.h>

void printarr(int *a, int n){
  for(int i = 0; i<n; i++)
    printf("%4d", a[i]);
  printf("\n");
}

void double_selection_sort(int *a, int n){
  int l = 0, r = n-1;

  while(r-l > 1){
    int min = a[l], mini = l, max = a[l], maxi = l;
    for(int i = l+1; i<=r; i++){
      if(a[i] >= max){
        max = a[i];
        maxi = i;
      }
      if(a[i] <= min){
        min = a[i];
        mini = i;
      }
    }
    int tmp = a[l];
    a[l] = min;
    a[mini] = tmp;

    tmp = a[r];
    a[r] = max;
    a[maxi] = tmp;

    l++;
    r--;
  }
}

int main(){

  const int n = 20;
  int *b = (int*)calloc(n, sizeof(int));

  srand(time(NULL));
  for(int i = 0; i<n; i++)
    b[i] = rand()%100;

  printarr(b, n);

  double_selection_sort(b, n);

  printarr(b, n);

  return 0;
}
