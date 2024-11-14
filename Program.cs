// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
string s = "12 + 13 - 2 * 4 + 8 / 3 * 4 % 5 + 10";
string a = "12 + 13 * 2 - 10 / 5";
string b = "1232+10";

bool PrecedenceCheck(string a, string b)
{
    int x,y;
    if (a == "*" || a == "/")
    {
        x = 1;
    }
    else x = 0;
    if(b == "*" || b == "/")
    {
        y = 1;
    }
    else y = 0;

    if(x==y) return true
   


    return x > y;
}
// first take 3 numbers and two operator 
// check which operator has higher precedece
// -calculate higher precedence operator -> 
//-> repeat the first step again
// for a  -> 12 + 13 * 2
 // 13 * 2 has higher precedence so -> 26
 // now the string becomes 12 + 26 -10 /5
 // taking three 12 + 26 -10 
 // + has higher precedence so -> 12 + 26= 38 
 // now the string becomes 38-10/5  
 // taking three 38 - 10 / 5
 // 10/5 has higher precedence so - > 10/5=2
 // now the string becomes 38-2 
 // two operand left so calculate normally -> 38-2=36


// split the string using .split function -> apply whitespaces in the textDisplay

// now check the odd indexes which are basically operators
// check two odd index which has higher precedence --> make a fucntion to check the higher precendence 
// if index =3 has higher precedence than index 1 then
//-> calculate valaue of index 2 (operator at index 3) value of index 4 
//-> now store the value at -> index 2 and delete index 3,4;
// -> keep doing it untill ther is one operator left and finally return the result 
 
string[] value=s.Split(' ');
List<string> list = new List<string>();
foreach(string i in value)
{
    list.Add(i);
}
for(int i=1; i<list.Count; i++)
{ 
    if(list.Count > 3)
    {

    }
    else
    {

    }
    
}