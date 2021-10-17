#include <stdio.h>

int i = 0;
int a[2] = {1, 1};

void p(int *x, int *y) {
  *x = *x + 1;
  i++;
  *y = *y + 1;
}

int main() {
  p(&a[i], &a[i]);
  printf("%d %d\n", a[0], a[1]);
}