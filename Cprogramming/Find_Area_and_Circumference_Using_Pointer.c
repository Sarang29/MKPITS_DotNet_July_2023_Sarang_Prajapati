#include<stdio.h>
void calculate(int r,float *a,float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
}
int main()
{
	float radius;
	float area,circ;
	printf("enter radius");
	scanf("%f",&radius);
	calculate(radius,&area,&circ);
	printf("area is %f",area);
	printf("circumference is %f",circ);
}
