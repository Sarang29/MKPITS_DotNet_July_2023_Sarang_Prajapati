// Wap to read information of students contains:- Name,Roll no.,Birthdate,Admission date.Calculate age of students at the time of Admission//
#include<stdio.h>
struct student
{
	int roll_no;
	char name[20];
	struct
	{
		int date;
		int month;
		int year;
	}
	birthdate,addate;
};
void main()
{
	struct student stud[3];
	int counter,p;
	for(counter=0;counter<3;counter++)
	{
		printf("Enter Roll no., Name :");
		scanf("%d%s",&stud[counter].roll_no,&stud[counter].name);
		printf("Enter Birthdate");
		scanf("%d-%d-%d",&stud[counter].birthdate.date,&stud[counter].birthdate.month,&stud[counter].birthdate.year);
		printf("Enter Admiddion Date :");
		scanf("%d-%d-%d",&stud[counter].addate.date,&stud[counter].addate.month,&stud[counter].addate.year);
	}
	for(counter=0;counter<3;counter++)
	{
		p=stud[counter].addate.year-stud[counter].birthdate.year;
		printf("\n Age of Student At The Time Of Admission");
		printf("\t%d years",p);
	}
}
