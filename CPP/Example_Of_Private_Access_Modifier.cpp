#include<iostream>
using namespace std;
class student 
{
	private:
		int roll_no;
		public:
			void display()
			{
				cout<<"Roll No.:="<<roll_no;
			}
			void setdata(int r)
			{
				roll_no=r;
			}
};
int main()
{
	student s1;
	int rn;
	cout<<"Enter Roll No.:";
	cin>>rn;
	s1.setdata(rn);
	s1.display();
	
}
