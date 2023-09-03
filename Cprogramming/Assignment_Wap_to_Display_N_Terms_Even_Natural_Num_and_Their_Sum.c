//Display N Terms of even natural number & their sum//
#include<stdio.h>
int main()
{
	int num;
	int i;
	int sum=0;
	printf("Enter number:");
	scanf("%d",&num);
	for(i=1;i<num;i++)
	{
		printf("\n%d",2*i);
		sum=sum+(2*i);
	}
	printf("\n___________________________________________________");
	printf("\n Sum Of N Terms of Even Natural Number:%d\n",sum);
}
