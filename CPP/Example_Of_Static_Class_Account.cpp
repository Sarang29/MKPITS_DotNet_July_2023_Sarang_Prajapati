#include<iostream>
using namespace std;
class Account
{
	public:
		int Acc_no;
		int balance;
	 	static float Roi;
		Account(int Acc_no,int balance)
		{
			this -> Acc_no=Acc_no;
			this -> balance=balance;
		}
		void display()
		{
			cout<<"Account Number:"<<Acc_no<<endl;
			cout<<"Balance:"<<balance<<endl;
			cout<<"Rate Of Interest:"<<Roi<<endl;
			cout<<"-------------------------------"<<endl;
		}
};
float Account::Roi=9.5f;
int main()
{
	Account A1=Account(123,2000);
	Account A2=Account(212,3000);
	Account A3=Account(313,4000);
	A1.display();
	A2.display();
	A3.display();
	
	return 0;
}
