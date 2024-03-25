using System.Security.Authentication;

namespace Third_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // HomeWork

            //1.Задание 1

            //Напишите программу -консольный калькулятор.Создайте две переменные с именами operand1 и operand2.
            //Задайте переменным некоторые произвольные значения.Предложите пользователю ввести знак арифметической операции.
            //Примите значение, введенное пользователем, и поместите его в строковую переменную strign.
            //Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
            //Выведите на экран результат выполнения арифметической операции.
            //В случае использования операции деления, организуйте проверку попытки деления на ноль.
            //И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.


            //float operand1 = 4;
            //float operand2 = 0;

            //Console.WriteLine($"Есть число {operand1} {operand2} - выберите номер операции которую хотите совершить ");

            //Console.WriteLine("1. + ");
            //Console.WriteLine("2. - ");
            //Console.WriteLine("3. * ");
            //Console.WriteLine("4. / ");

            //string answer = Console.ReadLine();

            //switch (Int32.Parse(answer))
            //{
            //    case 1:
            //        Console.WriteLine($"Ответ {operand1 + operand2}");

            //        break;
            //    case 2:
            //        Console.WriteLine($"Ответ {operand1 - operand2}");

            //        break;
            //    case 3:
            //        Console.WriteLine($"Ответ {operand1 * operand2}");

            //        break;
            //    case 4:
            //        if (operand1 == 0 || operand2 == 0)
            //        {
            //            Console.WriteLine("Число не может быть поделено на 0");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Ответ {operand1 / operand2}");
            //        }

            //        break;

            //}



            // Задание 2

            //Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100].
            //Если да, то укажите, в какой именно промежуток.
            //Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение


            //Console.WriteLine("Введите число от 0 до 100 или больше");

            //int number = Int32.Parse(Console.ReadLine());
            //bool answer = false;


            //switch (number)
            //{
            //    case int when (number > -1 && number < 15):
            //        Console.WriteLine("Ваше число  входит в диапазон от 0 до 14");
            //        break;
            //    case int when (number > 14 && number < 36):
            //        Console.WriteLine("Ваше число входит в  диапазон от 15 до 35");
            //        break;
            //    case int when (number > 35 && number < 51):
            //        Console.WriteLine("Ваше число входит в  диапазон от 36 до 50");
            //        break;
            //    case int when (number > 50 && number <= 101):
            //        Console.WriteLine("Ваше число  входит  в  диапазон от 51 до 100");
            //        break;
            //    default:
            //        Console.WriteLine("Ваше число не входит не в один диапазон от 0 до 100");
            //        break;
            //}



            // Задание 3
            //Напишите программу русско - английский переводчик.
            //Программа знает 10 слов о погоде.
            //Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
            //Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.

            //Console.WriteLine("Введите слово на русском о погоде например 'ветер и туман ' и получите его перевод на английский");

            // string answer = Console.ReadLine();

            //switch (answer)
            //{
            //    case "Дождь": Console.WriteLine("Rain");break;
            //    case "Солнце": Console.WriteLine("Sun"); break;
            //    case "Ветер": Console.WriteLine("Wind"); break;
            //    case "Туман": Console.WriteLine("Fog"); break;
            //    case "Град": Console.WriteLine("Hail"); break;
            //    case "Сумерки": Console.WriteLine("Twilight"); break;
            //    case "Мгла": Console.WriteLine("Haze"); break;
            //    case "Облачно": Console.WriteLine("Cloudy"); break;
            //    case "Снег": Console.WriteLine("Snow"); break;
            //    case "Гроза": Console.WriteLine("Storm"); break;
            //}





            //  Задание 4
            //Напишите программу, которая будет выполнять проверку чисел на четность.
            //Предложите два варианта решения поставленной задачи.

            //Вариант 1.
            //Console.WriteLine("Введите число а я проверю его на чётность");

            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Число чётное");
            //}
            //else
            //{
            //    Console.WriteLine("Число не чётное");
            //}

            //Вариант 2.
            //Console.WriteLine("Введите число а я проверю его на чётность");

            //int number = int.Parse(Console.ReadLine());

            //switch (number % 2)
            //{
            //    case 0:
            //        Console.WriteLine("Число чётное"); break;
            //    default:
            //        Console.WriteLine("Число не чётное");
            //        break;
            //}



            ////////То что делали на занятие 

            // Дано значение числа pi, которое равно 3,141592653 и значение числа Эйлера е, которое равно 2,7182818284 590452.
            // Создайте две переменные, присвойте им значения числа pi и числа е и выведите их на экран без потери точности.

            //double numberPI = 3.141592653;
            //Console.WriteLine(numberPI);
            //decimal numberAllera = 2.7182818284590452m;
            //Console.WriteLine(numberAllera);

            //Создайте три строковые переменные и присвойте им значения: "\nмоя строка 1”; "\tмоя строка 2”; "\aмоя строка 3".
            //Выведите значение каждой переменной на экран. Какие отличия вы увидели? Сделайте выводы.

            //string lineOne = "\nмоя строка 1";
            //string lineTwo = "\tмоя строка 2";
            //string lineTree = "\aмоя строка 3";

            //Console.Write(lineOne + lineTwo + lineTree);


            //Используя Visual Studio, создайте проект по шаблону Console Application.
            //Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r. Используя формулу πR2, вычислите площадь круга и выведите результат на экран.


            //double pi = 3.14;
            //double radius = double.Parse(Console.ReadLine());
            //double square = pi * (Math.Pow(radius,2));
            //Console.WriteLine(square);

            //Напишите программу расчета объема – V и площади поверхности – S цилиндра. Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h.
            //Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR(R+h).



        }
    }
}
