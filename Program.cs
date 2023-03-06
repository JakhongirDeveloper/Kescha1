// System.Console.Write("Enter you name : ");
// string name=Console.ReadLine();
// Console.WriteLine($"Hello, {name}!");
// System.Console.Write("Enter you age : ");
// int age=Convert.ToInt32(Console.ReadLine());
// if (age>18)
// {
//         System.Console.WriteLine($"Welcome {name}!");
// }
// else if (age<18)
// {
//         System.Console.WriteLine("You are not allowed to enter if you are under 18 years old!");
// }
// //literal string
// string greeting="\tHello,\n\"Jahongir\"";
// Console.WriteLine(greeting);
// //verbatim string
// string filePath=@"C:\televion.txt";
// Console.WriteLine(filePath);
// //interpolated  string 
// Console.Write("Enter you name : ");
// string name =Console.ReadLine();
// string greeting=$"Hello, \"{name}\"";
// Console.WriteLine(greeting);
// //Int16-5 xonali sonarni o'z ichiga oladi
// Console.WriteLine(Int16.MaxValue);
// Console.WriteLine(Int16.MinValue);
// //Int32-10 xonali sonlarni o'z ichiga oladi
// Console.WriteLine(Int32.MaxValue);
// Console.WriteLine(Int32.MinValue);
// //Int64-19 xonali sonlarni o'z ichiga oladi
// Console.WriteLine(Int64.MaxValue);
// Console.WriteLine(Int64.MinValue);
// Console.Write("Enter nambers : ");
// float son=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(son);
// ishlatiladigan sonlarning turlari >> short , int , long 
//short son=90;
//int son=100092823;
// long son = 5_869_324_363_748_926_439;
// Console.WriteLine(son);
// Console.WriteLine($"The size of short date type : {sizeof(short)}");
// Console.WriteLine($"The size of int date type : {sizeof(int)}");
// Console.WriteLine($"The size of long date type : {sizeof(long)}");
// Console.WriteLine($"The size of Max short date type : {short.MaxValue}");
// Console.WriteLine($"The size of Min short date type : {short.MinValue}");
// Console.WriteLine($"The size of Max int date type : {int.MaxValue}");
// Console.WriteLine($"The size of Min int date type : {int.MinValue}");
// Console.WriteLine($"The size of Max long date type : {long.MaxValue}");
// Console.WriteLine($"The size of Min long date type : {long.MinValue}");
// Console.WriteLine($"The size of Max short date type : {ushort.MaxValue}");
// Console.WriteLine($"The size of Min short date type : {ushort.MinValue}");
// Console.WriteLine($"The size of Max int date type : {uint.MaxValue}");
// Console.WriteLine($"The size of Min int date type : {uint.MinValue}");
// Console.WriteLine($"The size of Max long date type : {ulong.MaxValue}");
// Console.WriteLine($"The size of Min long date type : {ulong.MinValue}");
// Console.WriteLine(10.78/8);
// string name="Jahongir";
// short age=22;
// Console.WriteLine($"Ismim : {name}");
// Console.WriteLine($"Yoshim : {age} da");
//float,double,decimal
//float ~6-9  butundan keyin shuncha sonlar aniqlikda oladi
//double ~15-16 butundan keyin shuncha sonlar aniqlikda oladi
//decimal ~26-29 butundan keyin shuncha sonlar aniqlikda oladi
// Console.WriteLine("\nHello New User!");
// float flo= 3.3f;
// double dou=3.4;
// decimal deci=3.5m;
// Console.WriteLine($"\nfloat ning syntax si : {flo}\n");
// Console.WriteLine($"double ning syntax si : {dou}\n");
// Console.WriteLine($"decimal ning syntax si : {deci}\n");
// Console.WriteLine($"{flo} + 1.8 = {flo+1.8}");
// Console.WriteLine($"{dou} + 2.2 = {dou+2.2}");
// Console.WriteLine($"{deci} + 1.9 = {3.5+1.9}");
// Console.WriteLine(3.3+1.1==4.4);
// double bir=3.3;
// double ikki=1.1;
// double sum=4.4;
// Console.WriteLine(bir+ikki==sum);
// double bir=0.3;
// double ikki=1.1;
// double sim=1.4;
// Console.WriteLine(bir+ikki==sim);
// decimal bir =0.3m;
// decimal ikki=1.1m;
// decimal sum =1.4m;
// Console.WriteLine(bir+ikki==sum);
//bool ma'lumot turi faqat true yoki false qiymatlarni qabul qiladi 
//masalan 
// bool isGirl= false;
// bool isBoy =true; shunga uxshagan ma'lumotlarni qabul qialadi
// //implicit casting kichik qiymatdan katta qiymatga o'tish 
// float pi=3.14f;
// double bigPi=pi;
// short age=22;
// decimal deciAge=age;
// Console.WriteLine(deciAge);
// Console.WriteLine($"PI ning float dagi qiymati : {pi}");
// Console.WriteLine($"PI ning double dagi qiymati : {bigPi}");
// //explicit casting ya'ni katta qiymatdan kichik qiymatga o'tish 
// int floraTypes=3286;
// short smallTypes=(short)floraTypes;
// Console.WriteLine(smallTypes);
// float pi = 3.14f;
// double bigPi = pi;
// int bigInteger = (int)bigPi;
// Console.WriteLine(bigInteger);

// Console.Write("\nEnter you name : ");
// string name = Console.ReadLine();
// Console.WriteLine($"\nHello , {name}!\n");
// Console.Write("Enter you age : ");
// string age=Console.ReadLine();
// Console.WriteLine("\nConverting....");
// int Age=Convert.ToInt32(age);
// Console.WriteLine($"\nSuccesfully converted! {age}\n");
// Console.Write("Enter you phone number : ");
// string phone=Console.ReadLine();
// Console.WriteLine("Converting...");
// long phoneNumber = Convert.ToInt64(phone);
// Console.WriteLine($"Succesfully converted phone number {phoneNumber}");

Console.Write("\nIsmingizni kiritng : ");
string ism=Console.ReadLine();
string info="Assalomu aleykum";
Console.WriteLine($"\n{info}!\n\nXush kelibsiz {ism}!\n");
Console.Write($"{ism} tug'ulgan yilingizni kiriting : ");
int tyil=Convert.ToInt32(Console.ReadLine());
int yosh = 2023-tyil;
Console.WriteLine($"\n{ism} siz hozirda {yosh} dasiz!\n");
Console.WriteLine("Kescha degan qush bor\n\nVa uni yoshi sizning yoshingizdan kichik bu natijada ko'ring!\n");
int k_age=3;
Console.WriteLine($"Keschaning yoshi sizning yoshingizdan {yosh-k_age} ga kichik!\n");