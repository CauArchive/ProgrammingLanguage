#include <stdio.h>

int i = 0;
int a[2] = {1, 1};

int* thunk(int* array, int i) { return &array[i]; }

void p(int x, int y, int* (*f)(int*, int)) {
  x++;
  *f(a, i) = x; 
  i++;
  y++;
  *f(a, i) = y;
}

int main() {
  p(a[i], a[i], thunk);
  printf("%d %d\n", a[0], a[1]);
}