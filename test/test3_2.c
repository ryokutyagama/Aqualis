/*=============================================================================================*/
/* Project name: test3_2 */
/* Project version: aaa */
/*---------------------------------------------------------------------------------------------*/
/* Generated by Aqualis (algorithm and equation analyzer for lightwave simulation) */
/* Aqualis version: aaa */
/* Generated date: 2023/10/17 2:40:05 */
/*=============================================================================================*/
#include <stdio.h>
#include <stdlib.h>
#include <complex.h>
#include <math.h>
#undef I
#define uj _Complex_I
typedef struct _testClass1
{
  int n1;
  double x1;
  double complex z1;
} testClass1;
typedef struct _testClass2
{
  testClass1 s2;
  testClass1 *t2;
  int t2_size[1];
} testClass2;
testClass2 *q;
int q_size[1]={ -1 };
testClass2 p;
int *xx;
int xx_size[1]={ -1 };
testClass1 *d;
int d_size[1]={ -1 };
testClass1 c;
int ic001;
int *i1001;
int i1001_size[1]={-1};
int main()
{
  d_size[0] = 4;
  d=(testClass1 *)malloc(sizeof(testClass1)*d_size[0]);
  xx_size[0] = 8;
  xx=(int *)malloc(sizeof(int)*xx_size[0]);
  q_size[0] = 5;
  q=(testClass2 *)malloc(sizeof(testClass2)*q_size[0]);
  p.s2.n1 = 100;
  p.s2.x1 = 2.0E2;
  p.s2.z1 = 3.0E2+uj*4.0E2;
  p.t2_size[0] = 3;
  p.t2=(testClass1 *)malloc(sizeof(testClass1)*p.t2_size[0]);
  q[0].t2_size[0] = 2;
  q[0].t2=(testClass1 *)malloc(sizeof(testClass1)*q[0].t2_size[0]);
  q[0].t2[1].n1 = 2000;
  p.t2[0].n1 = 1000;
  for(ic001=1; ic001<=d_size[0]; ic001++)
  {
    d[ic001-1].n1 = 1;
    d[ic001-1].x1 = 2.0E0;
    d[ic001-1].z1 = 3.0E0+uj*4.0E0;
  }
  i1001_size[0] = 10;
  i1001=(int *)malloc(sizeof(int)*i1001_size[0]);
  i1001[0] = 1;
  i1001[1] = 2;
  i1001[2] = 3;
  i1001[3] = 4;
  i1001_size[0] = -1;
  free(i1001);
  i1001_size[0] = 20;
  i1001=(int *)malloc(sizeof(int)*i1001_size[0]);
  i1001[0] = 1;
  i1001[1] = 2;
  i1001[2] = 3;
  i1001[3] = 4;
  i1001_size[0] = -1;
  free(i1001);
  printf("%8d\n",p.s2.n1);
  printf("%27.17e\n",p.s2.x1);
  printf("%27.17e%27.17e\n",creal(p.s2.z1),cimag(p.s2.z1));
  return 0;
}
