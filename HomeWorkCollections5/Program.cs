namespace HomeWorkCollections5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = { "1", "2", "1", "4"};
            string[] secondArray = { "3", "2", "4", "6"};

            List<string> unitedCollection = new();

            ShowArrays(firstArray);
            ShowArrays(secondArray);

            Console.WriteLine("\nНажмите любую кнопку для объединения массивов: ");
            Console.ReadKey();

            UniteArraysToCollection(unitedCollection,firstArray);
            UniteArraysToCollection(unitedCollection, secondArray);
            ShowList(unitedCollection);
        }

        static void ShowArrays(string[] stringArray)
        {
            foreach (string itemInFirstArray in stringArray)
            {
                Console.Write(itemInFirstArray + ",");
            }

            Console.Write("\n");
        }

        static void UniteArraysToCollection(List<string> unitedCollection, string[] stringArray)
        {
            foreach (string item in stringArray)
            {
                if(!unitedCollection.Contains(item))
                {
                    unitedCollection.Add(item);
                }
            }
        }

        static void ShowList(List<string> unitedCollection)
        {
            unitedCollection.Sort();

            foreach (var item in unitedCollection)
            {
                Console.Write(item + ",");
            }
        }
    }
}