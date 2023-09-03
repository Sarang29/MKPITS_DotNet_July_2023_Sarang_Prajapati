#include<stdio.h>
int main()
{
	int rem,num,sum=0,i;
	printf("Enter Number");
	scanf("%d",&num);
	for(i=num;num!=0;num=num/10)
	{
		rem=num%10;
		sum=sum+(rem*rem*rem);
	}
	if(sum==i)
	{
		printf("%d is Armstrong Number\n",i);
	}
	else
	{
		printf("%d is Not A Armstrong Number",i);
	}
}
