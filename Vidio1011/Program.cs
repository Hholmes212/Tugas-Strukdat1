//for loops

//int counter = 0;
//counter = counter + 1;
//Console.WriteLine(counter);
//counter = counter + 1;
//Console.WriteLine(counter);
//counter = counter + 1;
//Console.WriteLine(counter);
//counter = counter + 1;
//Console.WriteLine(counter);

//int counter = 0;
//counter++;
//Console.WriteLine(counter);
//counter++;
//Console.WriteLine(counter);
//counter++;
//Console.WriteLine(counter);
//counter++;
//Console.WriteLine(counter);


//int counter = 0;
//while (counter < 5)
//{
//    counter++;
//    Console.WriteLine(counter);
//}

//int counter = 0;
//while (counter < 5)
//{
//   Console.WriteLine(counter);
// counter++;
//}


//int counter = 0;
//while (true)
//{
//    Console.WriteLine(counter);
//    counter++;
//}

/*
int counter = 0;
do
{
   Console.WriteLine(counter);
   counter++;
}
while (counter < 5);
*/

using System.ComponentModel.DataAnnotations;
/*
for (
    int i = 0; //initialize (start)
    i < 5; //conditional
    i++) //incerement
{
    Console.WriteLine(i);
    // DO THE THING
}
*/

/*
for (int i = 0; i < 5; i++) 
{
    if(i == 3)
    {
        Console.WriteLine(i);
    }
}
*/

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");

    }
}