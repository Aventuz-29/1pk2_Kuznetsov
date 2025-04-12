namespace Task_23_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу со следующими функциями:
            1.Выведите информации о всех дисках в системе
            2.Выведите содержимое каталога C: \Users(названия папок)
            3.Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            a) Создание вложенного каталога “temp”
            b) Вывод информации о текущем каталоге(имя, родитель и тд)
            c) Вывод информации о вложенном каталоге
            4.Переместите каталог “temp” по пути “D:\work\newTemp”
            a) Реализуйте вывод информационного сообщения об успешном(или нет)
            перемещении
            5.Удалите каталог “D:\work\temp” и выведите сообщение об успешном(или нет)
            удалении.*/

            // 1. Вывод информации о всех дисках
            List<DriveInfo> driveInfos = DriveInfo.GetDrives().ToList();
            Console.WriteLine("Диски в текущей системе: \n");
            foreach (DriveInfo drive in driveInfos)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"{drive.Name}: Размер диска: {drive.TotalSize / 1024 / 1024 / 1024} Гб"
                + $"\t Доступное место на диске: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} Гб\n"
                + $"\tТип диска: {drive.DriveType} \n"
                + $"\tМетка диска: {drive.VolumeLabel} \n");
                }
                else
                    Console.WriteLine($"Диск не готов! Тип диска: {drive.DriveType}\n");
            }

            // 2. Вывод содержимого C:\Users
            string pathName = @"C:\Users";
            if (Directory.Exists(pathName))
            {
                Console.WriteLine($"Папки каталога {pathName}: ");
                List<string> list = Directory.GetDirectories(pathName).ToList();
                if(list.Count > 0)
                {
                    int n = 1;
                    foreach (string s in list)
                    {
                        Console.WriteLine(n + ": " + s);
                        n++;
                    }
                }
                else
                    Console.WriteLine("Нет папок.");
            }
            else
                Console.WriteLine($"Каталога {pathName} не существует.");
            // 3. Создание D:\work и работа в ней
            string work = @"D:\work";
            Directory.CreateDirectory(work);

            // a) Создание вложенного каталога "temp"
            string tempPath = "temp";
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\work");
            directoryInfo.CreateSubdirectory(tempPath);

            // b) Вывод информации о текущем каталоге
            DirectoryInfo workDir = new DirectoryInfo(work);
            Console.WriteLine("\nИнформация о текущем каталоге:");
            Console.WriteLine($"Имя: {workDir.Name}");
            Console.WriteLine($"Полный путь: {workDir.FullName}");
            Console.WriteLine($"Родительский каталог: {workDir.Parent}");
            Console.WriteLine($"Время создания: {workDir.CreationTime}");

            // c) Вывод информации о вложенном каталоге "temp"
            DirectoryInfo tempDir = new DirectoryInfo(tempPath);
            Console.WriteLine("\nИнформация о вложенном каталоге:");
            Console.WriteLine($"Имя: {tempDir.Name}");
            Console.WriteLine($"Полный путь: {tempDir.FullName}");
            Console.WriteLine($"Родительский каталог: {tempDir.Parent}");
            Console.WriteLine($"Время создания: {tempDir.CreationTime}");

            // 4.Перемещение каталога "temp" в "D:\work\newTemp"
            Console.WriteLine("\n4. Перемещение каталога 'temp' в 'D:\\work\\newTemp':");
            string newTempPath = Path.Combine(work, "newTemp");
            if (Directory.Exists(tempPath) && !Directory.Exists(newTempPath))
            {
                Directory.Move(tempPath, newTempPath);
                Console.WriteLine("Успешно перемещено в D:\\work\\newTemp");
            }
            else
            {
                Console.WriteLine("Ошибка: исходная папка не существует или новая уже есть");
            }

            // 5. Удаление temp (если остался)
            Console.WriteLine("\n5. Удаление D:\\work\\temp:");
            if (Directory.Exists(tempPath))
            {
                Directory.Delete(tempPath);
                Console.WriteLine("Успешно удалено");
            }
            else
            {
                Console.WriteLine("Папка уже удалена или не существует");
            }
        }
    }
}
