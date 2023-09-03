#include<stdio.h>
#include<string.h>
struct Book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct Book *ptr);
void main()
{
	struct Book b1;
	printf("Enter Title,Author and Book id");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
	printbook(&b1);
}
void printbook(struct Book *ptr)
{
	printf("\nTitle=%s",ptr->title);
	printf("\nAuthor=%s",ptr->author);
	printf("\nBook id=%d",ptr->bookid);
}
