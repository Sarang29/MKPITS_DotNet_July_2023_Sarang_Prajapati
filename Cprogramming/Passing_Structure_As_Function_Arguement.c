#include<stdio.h>
#include<string.h>
struct Book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct Book b1);
void main()
{
	struct Book b1;
	printf("Enter Title,Author and Book id");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
	printbook(b1);
}
void printbook(struct Book b1)
{
	printf("\ntitle=%s",b1.title);
	printf("\nauthor=%s",b1.author);
	printf("\nBook id=%d",b1.bookid);
}
