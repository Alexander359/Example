using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поменяйте редактор по умолчанию в GitBash");
            Console.WriteLine("git config --global core.editor \"editor--parameters\" ");
            Console.WriteLine("создайте тренировочный репозиторий локально");
            Console.WriteLine("git init");
            Console.WriteLine("добавьте файл");
            Console.WriteLine("git add . - добавить все измененные или новые файлы в репозитарий");
            Console.WriteLine("сделайте коммит");
            Console.WriteLine("git commit -m \"Текст комента\"");
            Console.WriteLine("привяжите репозиторий к уддаленому репозиторию");
            Console.WriteLine("git remote add origin https://github.com/Alexander359/Example.git");
            Console.WriteLine("выкачайте в другую папку копию созданного уддаленного репозитория");
            Console.WriteLine("git clone https://github.com/RusyaOne/CSharpAdvanced_19.01.2021.git");
            Console.WriteLine("Создайте репозиторий с ДЗ, добавьте ДЗ в Google Class");
            Console.WriteLine("ДЗ создан, а гуглу - вырвать бы глазз");
        }
    }
}
