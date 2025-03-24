using Task_14_04;

namespace Task_14_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определите класс User, который будет иметь статическое свойство CurrentUser,
            //представляющеетекущегопользователя, и метод для его установки.

            // Создаем пользователя
            User user1 = new User("Влад", 1);

            // Устанавливаем его как текущего
            User.SetCurrentUser(user1);

            // Получаем текущего пользователя
            User current = User.CurrentUser;
            Console.WriteLine($"Текущий юзер: {current.Name}, ID: {current.Id}");
        }
    }
}