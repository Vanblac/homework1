//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input  two  int  numbers");
int num1  =  Convert.ToInt32(Console.ReadLine());
int num2 =  Convert.ToInt32(Console.ReadLine());
if  (num2 < num1){
    Console.WriteLine($"{num1}  is greater");
}  
else{
    Console.WriteLine($"{num2} is greater");
}
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input  three  int  numbers");
int num1  =  Convert.ToInt32(Console.ReadLine());
int num2 =  Convert.ToInt32(Console.ReadLine());
int num3 =  Convert.ToInt32(Console.ReadLine());
int result =0;
int  result1 =0;
if (num1<num2 ){
    result1 = num2;
}
else{
    result1=num1;
};
if (result1 > num3  ){
    result = result1;
    Console.WriteLine($"{result} the biggest num");
}
else {
    result = num3;
    Console.WriteLine($"{result} the biggest num");
}
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("inputint number");
int  num  =  Convert.ToInt32(Console.ReadLine());
if (num==0){
    Console.WriteLine($"{num} not correction  number");
    Console.WriteLine("Input correction int number");
}
else  {
    if (num  % 2 == 0){
        Console.WriteLine($"{num} четное" );
}
    else{
        Console.WriteLine($"{num}  не  четное ");
}
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Input  int  number");
int num =Convert.ToInt32(Console.ReadLine());
int num1 = 1;
for (int i =  num1 ; i<=num ; i++ ){
   if  (i % 2==0){
    Console.WriteLine(i + " ");

   }
}
*/  