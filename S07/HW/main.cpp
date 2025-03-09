#include<iostream>
#include<string>
#include<Windows.h>

using namespace std;

class KeepTime
{
    string m_str;
    long long m_l1;
    long long m_l2;
public:
    KeepTime(const string& str)
        :m_str(str)
    {
        m_l1 = GetTickCount64();
    }
    ~KeepTime()
    {
        m_l2 = GetTickCount64();
        cout << m_str << ": ";
        cout << "l1 = " << m_l1;
        cout <<", l2 = " << m_l2;
        cout << ", l2-l1 = " << m_l2 - m_l1 << endl;
    }
};

int main()
{
    KeepTime t("for loop 365 double mul");
    double d = 1;
    for(int i=0; i<365; i++)
        d = d * 1.01;
    
    cout << "d = " << d << endl;
 
}