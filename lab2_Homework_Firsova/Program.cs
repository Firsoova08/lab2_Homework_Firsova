namespace lab2_Homework_Firsova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //int a=int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("Число четное");
            //}
            //else
            //{
            //    Console.WriteLine("Число не четное");
            //}
            //задание2
            Console.Write("Придумайте пароль:");
            string pin1=Console.ReadLine();
            Console.Write("Напишите пароль:");
            string pin2=Console.ReadLine();
            if (pin1==pin2)
            {
                Console.WriteLine("Пароль принят");
            }
            else
            {
                Console.WriteLine("Пароль не принят");
            }
        }
    }
}
