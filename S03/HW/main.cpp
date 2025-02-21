#include<iostream>
#include<string.h>

class Student
{
    public:
        int m_stdNum;
        char m_FirstName[20];
        char m_LastName[20];
        int m_CoursesPassed;
        int m_Credits[40];
        double m_Grades[40];
        char* m_CourseNames[40];

        void name_copy(const char* p, char* copy_p)
        {
            while(*p)
            {
                *copy_p = *p;
                copy_p++;
                p++;
            }
            *copy_p = *p;
        }

        Student(int stdnum, const char* fname, const char* lname)
        {
            m_stdNum = stdnum;
            name_copy(fname,m_FirstName);
            name_copy(lname,m_LastName);

            std::cout << "StdNum: " << m_stdNum
                      << ", First Name: " << m_FirstName
                      << ", Last Name: " << m_LastName << std::endl;
        }

        ~Student()
        {
            std::cout << "StdNum: " << m_stdNum
                      << ", First Name: " << m_FirstName
                      << ", Last Name: " << m_LastName << std::endl;
        }

        double GetGPA()
        {
            double sumGrade = 0;
            int SumCredit = 0;
            for(int i=0; i<m_CoursesPassed; i++)
            {
                sumGrade += m_Credits[i] * m_Grades[i];
                SumCredit += m_Credits[i];
            }
            return sumGrade / SumCredit;
        }

        void list_courses()
        {
            for(int i=0; i<m_CoursesPassed; i++)
            {
                std::cout << m_CourseNames[i] << ": "
                          << m_Credits[i] << ": "
                          << m_Grades[i] << std::endl;   
            }
        }

        void register_course(int credits, const char* name, double grade)
        {
            m_Credits[m_CoursesPassed] = credits;
            m_Grades[m_CoursesPassed] = grade;

            char* namecopy = new char[strlen(name)+1];
            strcpy(namecopy,name);
            m_CourseNames[m_CoursesPassed] = namecopy;
            m_CoursesPassed++;
        }
};


int main()
{
    Student s(3423, "asdf", "lasdkfj");
    s.m_CoursesPassed = 0;
    char bufc[20];
    double grade;
    int credits;

    while(true)
    {
        std::cout << "course name? ";
        std::cin >> bufc;
        if(*bufc == 'x')
            break;

        std::cout << "course credits? ";
        std::cin >> credits;
        std::cout << "course grade? ";
        std::cin >> grade;

        s.register_course(credits, bufc, grade);
    }

    s.list_courses();
    
    std::cout << s.GetGPA() << std::endl;
    return 0;
}