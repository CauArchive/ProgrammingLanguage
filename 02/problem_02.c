#include <stdio.h>

int i = 0;
int a[2] = {1, 1};

void p(int *x, int *y) {
  (*x)++;
  i++;
  (*y)++;
}

int main() {
  p(&a[i], &a[i]);
  printf("%d %d\n", a[0], a[1]);
}