namespace HomeWorkCollections5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = { "1", "2", "1", "4"};
            string[] secondArray = { "3", "2", "4", "6"};

            List<string> unitedCollection = new();

            ShowArrays(firstArray, secondArray);

            Console.ReadKey();
            UniteArraysToCollection(firstArray, secondArray, unitedCollection);
            ShowList(unitedCollection);
        }

        static void ShowArrays(string[] firstArray, string[] secondArray)
        {
            foreach (string itemInFirstArray in firstArray)
            {
                Console.Write(itemInFirstArray + ",");
            }

            Console.Write("\n");

            foreach (string itemInSecondArray in secondArray)
            {
                Console.Write(itemInSecondArray + ",");
            }

            Console.WriteLine("\nНажмите любую кнопку для объединения массивов: ");
        }

        static void UniteArraysToCollection(string[] firstArray, string[] secondArray, List<string> unitedCollection)
        {
            loop:
            foreach (var item in firstArray)
            {

                if(unitedCollection.Contains(item))
                {
                    continue;
                }
                else unitedCollection.Add(item);
            }

            if(firstArray != secondArray)
            {
                firstArray = secondArray;
                goto loop;
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