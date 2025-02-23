#include<iostream>
#include<stdlib.h>
using namespace std;

class MyList
{
    public:
        int m_size;
        int* m_pnums;

    MyList(int size, int* nums):m_size(size)
    {
        m_pnums = (int*)malloc(sizeof(int)*size);
        int i;
        for(i=0; i<m_size; i++)
        {
            m_pnums[i] = nums[i];
        }
    }

    void Print_List()
    {
        cout<<"{";
        for(int i=0; i<m_size; i++)
        {
            if(i == m_size-1)
                cout << m_pnums[i];
            else
                cout << m_pnums[i]<<",";
        }
        cout <<"}"<<endl;
    }


    void append(int x)
    {
        resize(m_size+1);
        m_pnums[m_size-1] = x;
    }


    void pop()
    {
        if(m_size>0)
            resize(m_size-1);
    }

    int Count(int y)
    {
        int count = 0;
        for(int i=0; i<m_size; i++)
        {
            if(m_pnums[i] == y)
                count++;
        }
        return count;
    }

    private:
        void resize(int newsize)
        {
            int* newMem = (int*)malloc(sizeof(int)*newsize);
            for(int i=0; i<m_size; i++)
            {
                newMem[i] = m_pnums[i];
            }
            free(m_pnums);
            m_size = newsize;
            m_pnums = newMem;
        }
};

int main()
{
    int nums[5] = {1,2,3,4,5};
    MyList m(5,nums);
    m.Print_List();

    m.append(14);
    m.append(21);
    m.Print_List();

    m.pop();
    m.Print_List();

    m.append(2);
    m.append(2);
    m.Print_List();

    cout<<m.Count(2)<<endl;
}