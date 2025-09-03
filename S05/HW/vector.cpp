#include<iostream>
using namespace std;

class Vector_int
{
    int m_size;
    int m_capacity;
    int* m_nums;

public:
    Vector_int()
    {
        m_size = 0;
        m_capacity = 0;
        m_nums = new int[m_capacity];
    }


    void push_back(int x)
    {
        if(m_capacity <= m_size)
        {
            resize(m_size+1);
            m_nums[m_size-1] = x;
        }
        else
        {
            m_nums[m_size] = x;
            m_size++;
        }
    }

    int size()
    {
        return m_size;
    }

    int at(int i)
    {
        if(i>=0 && i<m_size)
            return m_nums[i];  
        return -1;        
    }

    void insert(int pos, int x)
    {
        if(pos<0 || pos>=m_size)
            cout<< "Index out of range"<<endl;

        else
        {
            if(m_capacity <= m_size)
            {
                resize(m_size+1);
                for(int i=m_size-1; i>pos; i--)
                    m_nums[i] = m_nums[i-1];
                m_nums[pos] = x;
            }
            else
            {
                m_size++;
                for(int i=m_size-1; i>pos; i--)
                    m_nums[i] = m_nums[i-1];
                m_nums[pos] = x;
            }
        }
    }


    void erase(int pos)
    {
        if(pos<0 || pos>=m_size)
            cout<< "Index out of range"<<endl;
        else
        {
            for(int i=pos; i<m_size-1; i++)
                m_nums[i] = m_nums[i+1];
            m_size--;
        }
    }


    int capacity()
    {
        return m_capacity;
    }

    void clear()
    {
        m_size = 0;
    }

    private:
    void resize(int newsize)
    {
        if(m_capacity < newsize)
        {
            if(m_capacity == 0)
                m_capacity = 1;
            else
                m_capacity *= 2;
            
            int* newnums = new int[m_capacity];
            for(int i=0; i<m_size; i++)
                newnums[i] = m_nums[i];

            delete[] m_nums;
            m_nums = newnums;
        }
        m_size = newsize;
    }
};

int main()
{
    Vector_int nums;
    nums.push_back(5);
    nums.push_back(10);

    cout << "{";
    for(int i=0; i<nums.size(); i++)
    {
        if(i < nums.size()-1)
            cout << nums.at(i) << ", ";
        else
            cout << nums.at(i) << "}\t capacity: " << nums.capacity() << endl;
    }


    nums.insert(0,2);
    nums.insert(2,8);
    cout << "{";
    for(int i=0; i<nums.size(); i++)
    {
        if(i < nums.size()-1)
            cout << nums.at(i) << ", ";
        else
            cout << nums.at(i) << "}\t capacity: " << nums.capacity() << endl;
    }



    nums.erase(3);
    cout << "{";
    for(int i=0; i<nums.size(); i++)
    {
        if(i < nums.size()-1)
            cout << nums.at(i) << ", ";
        else
            cout << nums.at(i) << "}\t capacity: " << nums.capacity() << endl;
    }


    nums.clear();
    cout << "size: " << nums.size() << "\t capacity: " << nums.capacity() << endl;
}


int main2()
{
    Vector_int nums;
    for(int i=0; i<60; i++)
    {
        cout << "capacity: " << nums.capacity()
             << "\tsize: " << nums.size() 
             << endl;
        nums.push_back(i);
    }
    return 0;
}