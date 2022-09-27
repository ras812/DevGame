using System;
using System.Collections.Generic;
using System.Reflection;

namespace TypesInCSharp
{
    public class AssemblyInfo
    {
        private readonly List<Type> _ltypes = new List<Type>();
        public int AssemblyCounts { get; private set; }
        public int TypeCountsInAllAssemblies { get; private set; }
        public int ReferenceTypeCounts { get; private set; }
        public int ValueTypeCounts { get; private set; }
        public int InterfaceTypeCount { get; private set; }

        public string TypeWithMaxMethodsCount { get; private set; }


        public AssemblyInfo()
        {
            _ltypes = GetTypesList();
            AssemblyCounts = GetAssemblyCounts();
            TypeCountsInAllAssemblies = GetTypeCountsInAllAssemblies();
            
            GetRefValInterTypesCount(out int refTCount, out int valTCount, out int interTCount);
            ReferenceTypeCounts = refTCount;
            ValueTypeCounts = valTCount;
            InterfaceTypeCount = interTCount;

            TypeWithMaxMethodsCount = GetTypeWithMaxMethodsCount();
        }

        private List<Type> GetTypesList()
        {
            List<Type> Lt = new List<Type>();

            Assembly[] assembliesArray = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly asm in assembliesArray)
            {
                foreach (var item in asm.GetTypes())
                {
                    Lt.Add(item);
                }
            }

            return Lt;
        }

        private int GetAssemblyCounts()
        {
            var ass = AppDomain.CurrentDomain.GetAssemblies();
            return ass.Length;
        }

        private int GetTypeCountsInAllAssemblies()
        {
            return _ltypes.Count;
        }

        private void GetRefValInterTypesCount(out int refTCount, out int valTCount, out int interTCount)
        {
            refTCount = 0;
            valTCount = 0;
            interTCount = 0;

            foreach (var item in _ltypes)
            {
                if (item.IsClass)
                {
                    refTCount++;
                }
                else if (item.IsValueType)
                {
                    valTCount++;
                }
                else if (item.IsInterface)
                {
                    interTCount++;
                }
            }
        }

        private string GetTypeWithMaxMethodsCount()
        {
            Dictionary<string, int> methodsInTypeCount = new Dictionary<string, int>();
            foreach (var item in _ltypes)
            {
                if (!methodsInTypeCount.ContainsKey(item.Name))
                {
                    methodsInTypeCount.Add(item.Name, item.GetMethods().Length);
                }
            }

            int maxCount = 0;
            string nameOfTypeWithMaxMethodCount = "";
            foreach (var item in methodsInTypeCount)
            {
                if (item.Value >= maxCount)
                {
                    maxCount = item.Value;
                    nameOfTypeWithMaxMethodCount = item.Key;
                }
            }

            return nameOfTypeWithMaxMethodCount;
        }
    }

	public class ShowAllTypeInfo
	{
		public ShowAllTypeInfo()
		{
		}

		public void StartShowAllTypeInfo()
        {
            DisplayShowAllTypeInfo(new AssemblyInfo());
            
            while (true)
            {
                char c = Handlers.InPutHandler();
                if (c == '0')
                {
                    MainMenu m = new MainMenu();
                    m.StartMainMenu();
                    break;
                }
            }
		}

		private void DisplayShowAllTypeInfo(AssemblyInfo asi)
		{
            Console.Clear();
            Console.WriteLine($"General info by types in assemblies\n" +
                              $"================\n" +
                              $"Assemblies: {asi.AssemblyCounts}\n" +
                              $"Types in all assemblies: {asi.TypeCountsInAllAssemblies}\n" +
                              $"References type: {asi.ReferenceTypeCounts}\n" +
                              $"Values type: {asi.ValueTypeCounts}\n" +
                              $"Interface type: {asi.InterfaceTypeCount}\n" +
                              $"Type with max methods count: {asi.TypeWithMaxMethodsCount}\n" +
                              $"Longest methods name:\n" +
                              $"Method with max arguments:\n" +
                              $"================\n" +
                              $"[0] - [ MAIN MENU ]"
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

