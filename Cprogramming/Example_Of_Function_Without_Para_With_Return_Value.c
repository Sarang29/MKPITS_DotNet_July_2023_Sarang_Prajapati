#include<stdio.h>
void addition()
{
	int n1,n2;
	printf("enter 2 nos");
	scanf("%d %d",&n1,&n2);
	int result=n1+n2;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int result;
		result=addition();
		printf("result=%d",result);
		printf("\n do you want to contine,press y");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while (ch=='y');
}
