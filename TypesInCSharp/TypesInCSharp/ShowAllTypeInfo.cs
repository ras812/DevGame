using System;
namespace TypesInCSharp
{
    public class AssemblyInfo
    {
        public int AssemblyCounts { get; private set; }
        public int TypeCountsInAllAssemblys { get; private set; }
        public int ReferenceTypeCounts { get; private set; }

        public AssemblyInfo()
        {
            AssemblyCounts = GetAssemblyCounts();
        }

        private int GetAssemblyCounts()
        {
            var ass = AppDomain.CurrentDomain.GetAssemblies();
            return ass.Length;
        }

    }

	public class ShowAllTypeInfo
	{
		public ShowAllTypeInfo()
		{
		}

		public void StartShowAllTypeInfo(AssemblyInfo asi)
		{
            DisplayShowAllTypeInfo(asi);
		}

		private void DisplayShowAllTypeInfo(AssemblyInfo asi)
		{
            Console.Clear();
            Console.WriteLine($"General info by types:\n" +
                              $"================\n" +
                              $"Assemblys: {asi.AssemblyCounts}\n" +
                              $"Types in all assemblys:\n" +
                              $"References type:\n" +
                              $"Values type:\n" +
                              $"Inerface type:\n" +
                              $"Type with max methods:\n" +
                              $"Longest methods name:\n" +
                              $"Method with max arguments:\n" +
                              $"================\n" +
                              $"[0] - [ Quit program ]"
                             );
        }


        //Общая информация по типам
        //Подключенные сборки: 17
        //Всего типов по всем подключенным сборкам: 26103
        //Ссылочные типы: 20601
        //Значимые типы: 4377
        //Типы-интерфейсы:
        //Тип с максимальным числом методов:
        //Самое длинное название метода:
        //Метод с наибольшим числом аргументов:
        //Нажмите любую клавишу, чтобы вернуться в главное меню


    }
}

