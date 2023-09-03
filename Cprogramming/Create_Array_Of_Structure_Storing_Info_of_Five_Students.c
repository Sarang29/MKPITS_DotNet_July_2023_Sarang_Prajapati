//Array Of Struc
ture//
#include<stdio.h>
#include<string.h>
struct student
{
	int rollnumber;
	char name[10];
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter Rollnumber & name");
		scanf("%d",&stud[counter].rollnumber);
		scanf("%s",&stud[counter].name);
	}
	printf("Student Details");
	for(counter=0;counter<5;counter++)
	{
		printf("\n Rollnumber=%d",stud[counter].rollnumber);
		printf("\n Name=%s",stud[counter].name);
	}

}
