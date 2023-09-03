#include<stdio.h>
void main()
{
	int n1=15;
	int n2=18;
	int *p1=&n1;
	int *p2=&n2;
	printf("before swap *p1=%d,*p2=%d",*p1,*p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("\n After swap *p1=%d,*p2=%d",*p1,*p2);
}
