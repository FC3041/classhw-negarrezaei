#include<iostream>
#include<stdlib.h>
using namespace std;

class MyList
{
    public:
        int m_size;
        int m_capacity;
        int* m_pnums;

    MyList(int size, int* nums):m_size(size)
    {
        m_capacity = size;
        m_pnums = (int*)malloc(sizeof(int)*m_capacity);
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


        cout << "capacity: "<< m_capacity << "  size: "<< m_size << "\n"<< endl;
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

    void erase(int pos)
    {
        if(pos < m_size)
        {
            for (int i = pos; i < m_size-1; i++)
            {
                m_pnums[i] = m_pnums[i+1];
            }
            m_size--;
        }
    }

    private:
        void resize(int newsize)
        {
            if(newsize > m_capacity)
                m_capacity *= 2;

            int* newMem = (int*)malloc(sizeof(int)*m_capacity);
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

    for (int i = 0; i < 5; i++)
    {
        m.append(2);
    }
    m.Print_List();

    cout<< "Count: " <<m.Count(2)<<endl;

    m.erase(4);
    m.Print_List();
}