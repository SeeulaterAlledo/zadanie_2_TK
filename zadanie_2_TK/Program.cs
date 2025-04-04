using System;

namespace zadanie_2_TK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета баллов экзамена");

            // Максимальные баллы для каждого модуля
            const int maxDbModule = 22;
            const int maxSoftwareModule = 38;
            const int maxMaintenanceModule = 20;

            // Запрос баллов за каждый модуль
            int dbScore = GetModuleScore("Разработка, администрирование и защита баз данных", maxDbModule);
            int softwareScore = GetModuleScore("Разработка модулей программного обеспечения", maxSoftwareModule);
            int maintenanceScore = GetModuleScore("Сопровождение и обслуживание ПО", maxMaintenanceModule);

            
            int totalScore = dbScore + softwareScore + maintenanceScore;

            // Определение оценки
            string grade = CalculateGrade(totalScore);

            
            Console.WriteLine("\nРезультаты экзамена:");
            Console.WriteLine($"Общая сумма баллов: {totalScore}");
            Console.WriteLine($"Оценка: {grade}");

            
            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }

        public static int GetModuleScore(string moduleName, int maxScore)
        {
            int score;
            while (true)
            {
                Console.Write($"\nВведите баллы за модуль '{moduleName}' (максимум {maxScore}): ");
                if (int.TryParse(Console.ReadLine(), out score))
                {
                    if (score >= 0 && score <= maxScore)
                    {
                        return score;
                    }
                    Console.WriteLine($"Ошибка: баллы должны быть от 0 до {maxScore}");
                }
                else
                {
                    Console.WriteLine("Ошибка: введите целое число");
                }
            }
        }

        public static string CalculateGrade(int totalScore)
        {
            if (totalScore >= 56 && totalScore <= 80)
                return "5 (отлично)";
            else if (totalScore >= 32 && totalScore <= 55)
                return "4 (хорошо)";
            else if (totalScore >= 16 && totalScore <= 31)
                return "3 (удовлетворительно)";
            else if (totalScore >= 0 && totalScore <= 15)
                return "2 (неудовлетворительно)";
            else
                return "неопределено (некорректная сумма баллов)";
        }
    }
}