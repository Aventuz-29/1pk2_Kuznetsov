namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
            расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
            этом*/

            int year, month, day;
            
            Console.Write("Введите свой год рождения, в формате xxxx(2008): ");
            year = int.Parse(Console.ReadLine());

            Console.Write("Введите свой месяц рождения, в формате хx(06): ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Введите свой день рождения, в формате хx(02): ");
            day = int.Parse(Console.ReadLine());

            int age1 = DateTime.Now.Year - year;
            int age2 = DateTime.Now.Month - month;
            int age3 = DateTime.Now.Day - day;

            if (age1 >= 19 && age1 < 123)
                Console.WriteLine("Вы совершенно летний!");

            else if (age1 >= 18 && age2 >= 0 && age3 >= 0 && age1 < 123)
                Console.WriteLine("Вы совершенно летний!");

            else if (age1 <= 18 && age1 >= 0)
                Console.WriteLine("Вы несовершеннолетний!");

            else
                Console.WriteLine("Вы ввели некоректные данные!");
        }
    }
}