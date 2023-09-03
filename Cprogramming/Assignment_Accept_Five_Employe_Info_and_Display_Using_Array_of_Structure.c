// Employe Details//
#include<stdio.h>
#include<string.h>
struct employe
{
	int Id;
	char name[20];
	char designation[20];
	char department[20];
	int salary;
};
void main()
{
	struct employe Emp[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter Id,Name,Designation,Department & Salary");
		scanf("%d",&Emp[counter].Id);
		scanf("%s",Emp[counter].name);
		scanf("%s",Emp[counter].designation);
		scanf("%s",Emp[counter].department);
		scanf("%d",&Emp[counter].salary);
	}
	printf("Employee Details");
	for(counter=0;counter<5;counter++)
	{
		printf("Id:=%d\t",Emp[counter].Id);
		printf("Name:=%s\t",Emp[counter].name);
		printf("Desig:=%s\t",Emp[counter].designation);
		printf("Dept:=%s\t",Emp[counter].department);
		printf("Sal:=%d\t",Emp[counter].salary);
	}
}
