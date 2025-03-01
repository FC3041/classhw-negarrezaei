#include<iostream>

using namespace std;

class MyStr
{
    public:
    int m_size;
    char* m_PChars;

    MyStr():m_size(0),m_PChars(nullptr){};

    MyStr(const char* chars)
    {
        int i;
        for(i=0;chars[i]!='\0';i++);
        m_size = i+1;

        m_PChars = (char*)malloc(sizeof(char)*(m_size));
        for(i=0; i<m_size;i++)
        {
            m_PChars[i] = chars[i];
        }
        m_PChars[m_size] = '\0';
    }

    MyStr(const char* chars, int start, int count)
    :m_size(count)
    {
        m_PChars = (char*)malloc(sizeof(char)*(m_size+1));

        for(int i=0;i<m_size ;i++)
        {
            m_PChars[i] = chars[start+i];
        }
        m_PChars[count] = '\0';

    }

    void printStr()
    {
        cout << m_PChars << endl;
    }

    bool checkSubstr(const char* chars)
    {
       int size;
       for(size=0; chars[size]!= '\0'; size++);

       for(int i=0; i<(m_size-size+1); i++)
        {
            bool x = true;
            for(int j=0; j<size; j++)
            {
                if(chars[j] != m_PChars[i+j])
                {
                    x = false;
                    break;
                }    
            }
            if(x == true)
                return true;
        }
        return false;

    }

    int len()
    {
        int i;
        for(i=0; m_PChars[i]!='\0'; i++);
        return i;

        // or ===>
        // return m_size;
    }

    void add(const MyStr& s)
    {
        int newsize = m_size + s.m_size;
        char* newchar = (char*) malloc(sizeof(char) * (newsize+1));
        for(int i=0; i<m_size; i++)
            newchar[i] = m_PChars[i];
        
        for(int j=0; j<s.m_size; j++)
            newchar[j+m_size] = s.m_PChars[j];
        
        newchar[newsize] = '\0';
        free(m_PChars);
        m_PChars = newchar;
        m_size = newsize;
    }
};


int main()
{
    MyStr s1(" @123");
    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();

    // s2.checkSubstr("haji"); // TODO1
    if(s2.checkSubstr("haji") == 0)
        cout << "False"<< endl;
    else
        cout << "True"<< endl;

    cout <<s2.len()<< endl; //TODO2
    s2.add(s1); // TODO3 
    s2.printStr();
    
}