//Function Prototype Deposit Withdraw//
#include<stdio.h>
void deposit(int amt,int bal);
void withdrawl(int amt,int bal);
void main()
{
	int amt,bal=1000;
	printf("enter amount");
	scanf(" %d",&amt);
	deposit(amt,bal);
	withdrawl(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("\n amount deposited is %d",bal);
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	printf("\n amount with bal =%d",bal);
}
