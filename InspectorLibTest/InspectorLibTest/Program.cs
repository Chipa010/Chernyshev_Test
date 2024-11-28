using System;
using InspectorLib;

namespace InspectorLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();

            
            Console.WriteLine("Главный инспектор: " + inspector.GetInspector());
            Console.WriteLine("Название автоинспекции: " + inspector.GetCarInspection());

            if (inspector.SetInspector("Иванов И.И."))
            {
                Console.WriteLine("Главный инспектор успешно изменен на: " + inspector.GetInspector());
            }
            else
            {
                Console.WriteLine("Не удалось изменить главного инспектора.");
            }

           
            string generatedNumber = inspector.GenerateNumber("1234", "A", "75");
            Console.WriteLine("Сгенерированный госномер: " + generatedNumber);

            Console.WriteLine("Сотрудники автоинспекции:");
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }

            inspector.AddWorker("Петров П.П.");
            Console.WriteLine("После добавления нового сотрудника:");
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
}