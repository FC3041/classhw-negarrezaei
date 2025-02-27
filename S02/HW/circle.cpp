#include<iostream>
#include<math.h>
using namespace std;

class Circle
{
    public:
        double x;
        double y;
        double r;

        Circle(double p,double q,double w)
        {
            x = p;
            y = q;
            r = w;
        }


        double Primeter()
        {
            double P = 2 * M_PI * r;
            return P;
        }

        double Area()
        {
            double S = M_PI * r * r;
            return S;
        }

        double Distance(Circle c)
        {
            double x_diff = c.x - x;
            double y_diff = c.y - y;
            return sqrt(x_diff * x_diff + y_diff * y_diff);
        }


        void Point(double x2, double y2)
        {
            if(x2*x2 + y2*y2 < r)
                cout << "The point is inside the circle" << endl;

            else if(x2*x2 + y2*y2 == r*r)
                cout << "The point is on the circle" << endl;

            else
                cout << "The point is outside the circle" << endl;
        }

        double Distance2(double x2, double y2)
        {
            double x_diff = x2 - x;
            double y_diff = y2 - y;
            return sqrt(x_diff * x_diff + y_diff * y_diff);
        }
};


int main()
{
    Circle c1(0,0,5);

    double P = c1.Primeter();
    double S = c1.Area();

    cout << "Primeter = " << P << endl;
    cout << "Area = " << S << endl;


    Circle c2(8,9,3);
    double d = c1.Distance(c2);
    cout << "Distance = " << d << endl;


    double x2,y2;
    cin>>x2;
    cin>>y2;

    c1.Point(x2,y2);

    double d2 = c1.Distance2(x2,y2);
    cout << "Distance2 = " << d2 << endl; 
}