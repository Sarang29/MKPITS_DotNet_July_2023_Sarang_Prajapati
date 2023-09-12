#include<iostream>
using namespace std;
class person
{
	protected:
		string name;
};
class student: public person
{
	public:
		void setdata(string s)
		{
			name=s;
		}
		void displaydata()
		{
			cout<<"Name:"<<name;
		}
};
int main()
{
	student s1;
	s1.setdata("Chandu");
	s1.displaydata();
}
