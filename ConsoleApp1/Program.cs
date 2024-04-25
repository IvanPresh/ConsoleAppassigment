// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Runtime.Serialization;
using System.Transactions;

Console.WriteLine("Hello, World!");

string name = "\"precious\"";
Console.WriteLine(name);

string d = "one\nTwo\nThree"; //using the new line escapse
Console.WriteLine(d);

string t = @"ade\\joy\\tty\\car";
Console.WriteLine(t);

//arithmetic opperators examples +, -, /, *, ++, --, %
int num = 16;
int dnum = 4;
int result = num / dnum;
Console.WriteLine("result = {0}", result); //using a place holder syntax {0}
int y = 8;
int u= 3;
int remainder = y % u;
Console.WriteLine("remainder = {0}", remainder);


//Comparison operators and examples (==,  !=,  >, >=,  <,  <=)

int nm = 8;
int mn = 7;
Console.WriteLine(mn==nm);

Console.WriteLine(mn>=nm);

Console.WriteLine(mn!=nm);

//Assignment operattors: =, +=, -=, /=, *=, %=, &=

int p = 9;

 p += 4;  // p= p+4;

Console.WriteLine(p);
int pj = 5; 

pj -= 2; // pj= pj-2   // examples of  assignment operator 0f -=

Console.WriteLine(pj);

int Y = 6;

Y %= 2;  // Y= Y % 2;

Console.WriteLine(Y);

int P = 9;
P &= 7;  // P= P and 7;

Console.WriteLine(P);


//  conditional operators &&, ||(AND nd OR)
int T = 7;
int R = 5;
if (T == 7 && R==5)
    Console.WriteLine("Earth");

int D = 0;
int Q = 1;
if (D==0 ||  Q==5)
    Console.WriteLine("Life");

// Ternary operator  ?:

int NUM = 79;

bool DD7;

if (NUM ==7)

    DD7 = true;

else

    DD7 = false;

Console.WriteLine("NUM == 7 {0}", DD7);

//using ternary operator

int NUmber = 7;


bool ISnumber7 =  NUmber  ==7 ? true : false; // Ternary operator :condition ? first_expression : second_expression;


Console.WriteLine("NUmber ==7 {0}", ISnumber7);

int Temp = 32;
string weathercast = Temp < 20 ? "Cold" : "warm";

Console.WriteLine("Temp == 32{0}", weathercast);

//Arrays

int[] Singlenumber = { 1, 2, 3, 4 };

string[] months = { "Jan", "Feb", "Mar", "April", "May" };

string[] cars = { "Toyota", "Ford", "Chevrolet" };

foreach (int digit in Singlenumber)
{


    Console.WriteLine(digit);

}


//foreach (string month in months)
{

    Console.WriteLine(months[0]);

}


//foreach (string Motor  in cars)     
{
    Console.WriteLine(cars[2]);
    // Console.WriteLine(Motor);

}

// conditional statement and looping

//if else
//switch case
int K = 7;
int L = 9;

if (K == 9) 
{

    Console.WriteLine("K ==7  The world is sperical");

}
else
{

   Console.WriteLine("K !=7  The world is Flat");
}

//using ternary operation ?:

string Result= ( K >=7 ) ? "The world is spherical" : "The world is Flat"; //TERNARY Operator
{

    Console.WriteLine(Result);

}

int TemP= 20;

string TEmp = (TemP>18) ? "cold" : "warm";
{

    Console.WriteLine(TEmp);
}

//Switch Case
string Name = "January";

switch (Name) 
{
    case "March":
    {
            Console.WriteLine(" Narch");
            break;
    }
    case "April":
    {

            Console.WriteLine("April");
            break;
    }
    case "January":
    {

            Console.WriteLine("January");
            break;
            
    }
    default: 
    {
            Console.WriteLine("name not be found");
            break;
    }

}

// for


for (int i = 10; i <12; ++i)
{
    Console.WriteLine("i = " + i);
}

//dowhile

int M = 1;
do
{
    Console.WriteLine("M= "+ M);
    ++M;

}
while (M <=3);



Console.ReadKey();

