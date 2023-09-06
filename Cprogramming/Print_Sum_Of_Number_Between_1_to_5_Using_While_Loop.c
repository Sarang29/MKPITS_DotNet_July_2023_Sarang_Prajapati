#include<stdio.h>
int main()
{
	int counter=1;
	int sum=0;
	while(counter<=5)
	{
		sum=sum+counter;
		counter=counter+1;
	}
	printf("Sum=%d",sum);
}
