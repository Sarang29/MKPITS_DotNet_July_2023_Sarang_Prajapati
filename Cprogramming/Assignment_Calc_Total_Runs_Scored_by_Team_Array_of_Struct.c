#include<stdio.h>
struct team
{
	char name[20];
	int run;
};
void main()
{
	struct team player[11];
	int sum=0;
	int counter;
	for(counter=0;counter<11;counter++)
	{
		printf("Enter Name,Runs :");
		scanf("%s%d",&player[counter].name,&player[counter].run);
	}
	for(counter=0;counter<11;counter++)
	{
		sum=sum+player[counter].run;
	}
	printf("\nTotal Runs Scored by Team");
	printf("\n%d",sum);
}
