#include <stdio.h>

int i = 0;
int a[2] = {1, 1};

void p(int x, int y, int* x_address, int* y_address) {
  int* x_return_address = x_address + i;
  int* y_return_address = y_address + i;
  x++;
  i++;
  y++;
  *x_return_address = x;
  *y_return_address = y;
}

int main() {
  p(a[i], a[i], &a[i], &a[i]);
  printf("%d %d\n", a[0], a[1]);
}