#include <stdio.h>

int i = 0;
int a[2] = {1, 1};

void p(int x, int y, int* x_address, int* y_address) {
  int* x_return_address = x_address;
  int* y_return_address = y_address;
  x++;
  i++;
  y++;
  *x_address = x;
  *y_address = y;
}

int main() {
  p(a[i], a[i], &a[i], &a[i]);
  printf("%d %d\n", a[0], a[1]);
}

/*
value-result (call): a[0]=2, a[1]=1
value-result (return): a[0]=1, a[1]=2
name: a[0]=2, a[1]=2
*/