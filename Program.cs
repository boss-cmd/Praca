//Завдання 1 "Таблиця множення"
Console.WriteLine("До якого числа повинна йти таблиця (включно з цим числом)?");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Ось ваша таблиця множення:");
for(int a=1;a<n+1;a++){
    for(int b=1;b<n+1;b++){
        int c=a*b;
        Console.WriteLine($"{a}*{b}={c}");
    }
}

// Завдання 2 "Простота числа."
Console.WriteLine("Введіть число яке хочете перевірити на простоту:");
int n1=int.Parse(Console.ReadLine());
if(n1%2==0&&n1!=2 || n1%3==0&&n1!=3){Console.WriteLine("Це число зовсім не просте!");}
else{Console.WriteLine("Число просте!");}

// Завдання 3 "Числа Фібоначчі."
Console.WriteLine("Напишіть скільки чисел Фібоначчі треба вивести:");
int n2=int.Parse(Console.ReadLine());
int a1=0;
int b1=1;
Console.WriteLine($"Ось ваші {n2} чисел Фібоначчі:");
for(int j=0; j<n2;j++){
    if(j%2==0){Console.WriteLine(a1);
    a1=a1+b1;}
    else{Console.WriteLine(b1);
    b1=b1+a1;}
}

//Завдання 4 "Дільники числа"
Console.WriteLine("Напишіть число дільники якого хочете знайти:");
int n3=int.Parse(Console.ReadLine());
Console.WriteLine("Ось усі дільники цього числа: ");
for(int g=1; g<n3+1; g++){
if(n3%g==0){
    Console.WriteLine(g);
}
}

//Завдання 5 "Сортування і об'єднання двух массивів"
Console.WriteLine("Введіть 20 чисел (по 10 у кожному массиві, через ентер)");
int [] ar=new int [10];
int [] ar1= new int [10];
for(int bc=0; bc<10; bc++){
    ar[bc]=int.Parse(Console.ReadLine());
    ar1[bc]=int.Parse(Console.ReadLine());
}
int [] aro=new int [20];
for(int arv=0;arv<10;arv++){
    aro[arv]=ar[arv];
    aro[arv+10]=ar1[arv];
}
Array.Sort(aro);
Console.WriteLine("Ось значення з вашого відсортованого массиву з массивів: ");
for(int cif=0; cif<20; cif++){
    Console.WriteLine(aro[cif]);
}

// Завдання 6 "Значення в массиві що призводять до заданної сумми."

int [] arr= new int [10];
Console.WriteLine("Напишіть 10 цифр у цей массив: ");
for(int gh=0; gh<10; gh++){
    arr[gh]=int.Parse(Console.ReadLine());
}
Console.WriteLine("Введіть Значення сумми: ");
int S = int.Parse(Console.ReadLine());

Console.WriteLine("Натисніть ентер для закінчення роботи программи.");
Console.ReadLine();
