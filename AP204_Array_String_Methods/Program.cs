using System;

namespace AP204_Array_String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home work
            //Newspaper newspaper = new Newspaper("McDonlads", "Food", 14.5d, 10, DateTime.Now);

            //Book book = new Book("George Orwell", "Dedective", 15d, 1, DateTime.Now);

            //newspaper.Info();

            //newspaper.baseInfo();


            //Console.WriteLine("Book");

            //book.Info();
            //book.baseInfo();

            //book.Sell();
            //book.Sell();

            //book.baseInfo();
            #endregion


            //Array methods


            //int[] arr = { 1, 3, 5, 10, 19, 26, 70, 89,19, 99 };

            //int[] array = new int[20];
            //int result = Array.BinarySearch(arr, 89);

            //Console.WriteLine(arr[result]);

            //int arr2 = (int)arr.Clone();

            //arr.CopyTo(array,18);
            //foreach (int num in array)
            //{
            //    Console.WriteLine(num);
            //}

            //bool result = Array.Exists(arr, x => x == 119);

            //Console.WriteLine(result);

            //int res = Array.Find(arr,x=>x==119);
            //Console.WriteLine(res);

            //int[] findArr = Array.FindAll(arr, x => x == 19);

            //foreach (var item in findArr)
            //{
            //    Console.WriteLine(item);
            //}

            //if (findArr.Length < 5)
            //{
            //    Console.WriteLine("Sert kecerli deyil");
            //}

            //int index = Array.LastIndexOf(arr,19);
            //Console.WriteLine(index);


            //string[] strarr = { "Tural", "Shemsi" };


            //Array.Resize(ref arr, arr.Length + 1);

            //arr[arr.Length - 1] = 15;

            //Array.Reverse(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //char[] letters = { 'b', 'h', 'z', 'x', 'c', 'a' };


            //Array.Sort(letters);

            //foreach (var item in letters)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(letters.ToString());


            //String methods

            //string name = "Fatima";
            //string surname = "Hasanzade";

            //string fullname = String.Concat(name, " ", surname);


            string sentence = "Biz,dersde,oturmusuq";

            //Console.WriteLine(sentence.Contains("dersde otur"));

            string newSentence = sentence.Insert(4, "bugun ");

            //Console.WriteLine(newSentence);


            //bool result = sentence.StartsWith('B');
            //bool endResult = sentence.EndsWith("oturmusuq ");
            //Console.WriteLine(endResult);

            int index = sentence.LastIndexOf("s");

            string name = "l";

            //if (string.IsNullOrWhiteSpace(name))
            //{
            //    Console.WriteLine("White space");
            //}
            //else
            //{
            //    Console.WriteLine("Deyil");
            //}


            string another = sentence.Remove(3, 7);

            another = sentence.Replace("Biz", "bIZ");
            Console.WriteLine(another);

            string[] strArr = sentence.Split(',');

            foreach (var item in strArr)
            {
                Console.WriteLine(item);
            }

            string correct = string.Join(" ", strArr);

            Console.WriteLine(correct);


            string substr = correct.Substring(0,10)+"...";

            Console.WriteLine(substr);


            string trim = "  Hello  World  ";
            Console.WriteLine(correct.ToUpper());

            Console.WriteLine(trim.Trim()) ;
        }
    }
}
