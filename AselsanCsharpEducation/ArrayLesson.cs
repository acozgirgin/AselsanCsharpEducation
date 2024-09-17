using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }




    internal class CollectionLesson
    {

        private ArrayList arrayList = new ArrayList();
        
        private List<int> numbers = new List<int>();

        private List<Person> personList = new List<Person>();

        private Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();    

        private LinkedList<string> linkedList = new LinkedList<string>();

        private Queue<string> QueueAsNames = new Queue<string>();   

        private Stack<string> StackAsNames = new Stack<string>();   

        private Hashtable hashtable = new Hashtable();  

        private HashSet<string> hashSet = new HashSet<string>();



        public void HashSetExample()
        {
            hashSet.Add("abidin");
            hashSet.Add("can");
            hashSet.Add("ozgirgin");
            hashSet.Add("mahmut");
            hashSet.Add("sulo");
            hashSet.Add("apo");
            hashSet.Add("reco");

            foreach (var item in hashSet)
            {
                Console.WriteLine(item);    
            }

            

            

        }
        public void HasTableExample()
        {
            hashtable.Add(11, "abidin");
            hashtable.Add(22, "can");
            hashtable.Add(3, "ozgirgin");
            hashtable.Add(48, "mahmut");
            hashtable.Add(15, "sulo");
            hashtable.Add(76, "apo");
            hashtable.Add(37, "reco");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"key: {item.Key} value: {item.Value}");
            }

           

        }


        public void StackExample()
        {

            StackAsNames.Push("abidin");
            StackAsNames.Push("can");
            StackAsNames.Push("ozgirgin");

            foreach(var name in StackAsNames)
            {
                Console.WriteLine(name);
            }

            string name1 = StackAsNames.Pop(); // ustten sondan elemanı secer dondurur ve siler
            string name2 = StackAsNames.Pop(); // ustten sondan elemanı secer dondurur ve siler
            string name3 = StackAsNames.Pop(); // ustten sondan elemanı secer dondurur ve siler

        }

        public void QueueExample()
        {
            QueueAsNames.Enqueue("abidin");
            QueueAsNames.Enqueue("can");
            QueueAsNames.Enqueue("ozgirgin");

            foreach(var name in  QueueAsNames)
            {
                Console.WriteLine(name);
            }

            var name1= QueueAsNames.Dequeue(); // ilk elemandan baslayarak cikaririz
            var name2 = QueueAsNames.Dequeue();
            var name3 = QueueAsNames.Dequeue(); 


        }

        public void LinkedListExample()
        {

            linkedList.AddFirst("abidin");


        }

        public void DictionaryExample()
        {
            keyValuePairs.Add(key: 1, value: "ahmet");
            keyValuePairs.Add(key: 2, value: "ahmet");
            keyValuePairs.Add(key: 3, value: "ahmet");
        }

        public CollectionLesson()
        {
            //arrayleri newleme islemini constructordada yapabiliriz, ama yukardaki kullanım gibi olmasının bir sakıncası yok.
        }
        public void ArrayMethod()
        {
            //object input kabul ediyor --> Add herşeyi ekleyebiliriz.
            arrayList.Add("ahmet");
            arrayList.Add(2);
            arrayList.Add(23.1f);
            arrayList.Add(new Product());
        }

        public void AddList()
        {
            numbers.Add(2);
            numbers.Add(5);
            numbers.Remove(2);
        }

        public void ForEachLoop()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9 };

            //Iterasyon --> foreach
            foreach(var val in numbers)
            {
                Console.WriteLine($" number: {val}");
            }

            //Geleneksel index uzerınden donuyo
            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void AddPerson()
        {
            personList.Add(new Person() { Id = 1, Name = "abidin", Age = 23 });
            personList.Add(new Person() { Id = 1, Name = "can", Age = 23 });
            personList.Add(new Person() { Id = 1, Name = "abidin", Age = 23 });

            var p1 = new Person() { Id = 1, Name = "abidin ", Age = 23 };
            var p2 = new Person() { Id = 1, Name = "abidin ", Age = 23 };

            bool res1 = p1 == p2; // false doner --> referans addresslerini karsıılastırıyor sadece
            bool res2 = p1.Equals(p2);  // fale doner --> referans addresslerini karsılastırıyor.

        }




    }

    internal class ArrayLesson
    {

        int[] numbers = new int[5];
        string[] names = new string[10];
        Product[] products = new Product[5];

        //Object icinde array yapabiliriz.
        Object[] objects = new Object[5];   

        public void AddNumbers()
        {

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;


        }


        

    }
}
