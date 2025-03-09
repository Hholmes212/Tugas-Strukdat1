//int a = 2100000000;
//int b = 2100000000;
//int c = a + b;
//long c = a + b;
//long c = (long)a + (long)b;
//onsole.WriteLine(c);

//int a =(int)42.1;
//int b =(int)38.2;
//long c = checked(a + b);
//Console.WriteLine(c);

//double a = 42.1; //natural type
//float b = 38.2F;
//double c = a + b;
//Console.WriteLine(c);

//decimal a = 42.1M; //explicit type
//decimal b = 38.2M;
//decimal c = a + b;
//Console.WriteLine($"The answer is {c}");

//int a = 5;
//int b = 3;
// int b = 3; jika angka tidak lebih dari 10 maka code tersebut tidak jalan atau salah
//int c = a + b;

//bool myTest = c > 10;

//if (a +b > 10)

//if (myTest)// is true
//{
  //  Console.WriteLine("The answer is greater than 10.");
//} //otherwise
//else {

 //   Console.WriteLine("The answer is LESS than 10.");
//}

int a = 5;
int b = 3;
int c = 4;

if ((a + b + c > 10) && (a == b))

{
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second");
} 
else {

    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("Or the first number is not equal to the second");
}