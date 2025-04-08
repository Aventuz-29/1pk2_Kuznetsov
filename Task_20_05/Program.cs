namespace Task_20_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
            • Guest(только чтение)
            • User(чтение + комментарии)
            • Moderator(удаление контента)
            • Admin(полный доступ)
            Создайте метод, который проверяет, может ли пользователь выполнить действие(например, удалить пост). На основе уровня доступа выводите сообщение(например, "Ошибка: Недостаточно прав!").*/

            Check check = new Check();
            check.Authorization(AccessLevel.Moderator);
            check.Action();
        }
    }
}
