#include<iostream>
using namespace std;

class String
{   public:
    char* m_string;

    String(const char* str)
    {
        m_string = new char[len(str)+1];
        int i;
        for(i=0; i<len(str); i++)
            m_string[i] = str[i];
        m_string[i] = '\0';
    }
    String(){};

    int len(const char* p)
    {
        int i;
        for(i=0; p[i] != '\0'; i++)
        ;
        return i;
    }

    void assign(const char* num)
    {
        delete[] m_string;
        m_string = new char[len(num)+1];
        int i;
        for(i=0; i<len(num); i++)
            m_string[i] = num[i];
        m_string[i] = '\0';
    }

    char* c_str()
    {
        return m_string;
    }

    int size()
    {
        int i;
        for(i=0; m_string[i] != '\0'; i++)
            ;
        return i;
    }

    void append(const char* str)
    {
        int x = len(str);
        int y = len(m_string);
        char* newstr = new char[x+y+1];

        int j;
        for(int i=0; i<y; i++)
            newstr[i] = m_string[i];
        for(j=y; j<y+x; j++)
            newstr[j] = str[j-y];
        newstr[j] = '\0';

        delete[] m_string;
        m_string = newstr;
    }
    void append(const String &p)
    {
        return append(p.m_string);
    }
};

int main()
{
    String name("Ali");
    String name2;
    name2.assign("Mozhdeh");
    cout << name.c_str() << ": " << name.size() << endl;
    cout << name2.c_str() << ": " << name2.size() << endl;
    name.append(" + ");
    name.append(name2);
    name.append("\n");
    cout << name.c_str() << endl;
}