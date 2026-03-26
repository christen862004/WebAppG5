namespace WebAppG5.Models
{
    interface ISort
    {
        void Sort(int[] arr);
    }
    class BubbleSort:ISort
    {
        public void Sort(int[] arr)
        {
            //sort arr using Bubble Sort Alg
        }
    }
    //extend
    class SelectSort:ISort
    {
        public void Sort(int[] arr) { }
    }
    class ChrisSort : ISort
    {
        public void Sort(int[] arr) { }
    }

    //DIP + IOC + OC Principle
    class MyList //high level class
    {
        int[] arr;
        ISort SortRef; //abstartct class or interface
        public MyList(ISort sortAlg)//need inject constructor (di)
        {
            arr = new int[10];
            SortRef = sortAlg;//dont create but ask contrsturto paramete
        }
        public void SortList()
        {
            SortRef.Sort(arr);
        }
    }

    class MainTest
    {
        public void TEst()
        {
            MyList l1 = new MyList(new BubbleSort());//write
            MyList l2 = new MyList(new SelectSort());
            MyList l3 = new MyList(new ChrisSort());
            l1.SortList();//bublle Sort
            l2.SortList();//bublle Sort
        }
    }













    public class Parent<T>
    {
        public T Model { get; set; }
    }
    public class Child<T> : Parent<T>
    {

    }
    public class Child2 : Parent<dynamic>//lossly type view
    {

    }


    public class MyView
    {
        object viewdata;//field + private
        public object ViewData
        {
            get
            { return viewdata;}
            set
            { viewdata = value;}
        }
        public dynamic ViewBag
        {
            get
            { return viewdata; }
            set
            { viewdata = value; }
        }
    }

    public class TestClass
    {
        
        public void sum(int x,int y) {
            MyView v = new MyView();
            
            int z = x + y;
            Parent<int> p = new Parent<int>();//create object
            Child<string> c=new Child<string>();
            Child2 c2=new Child2();
            //c2.Model
        }

        public void Calc()
        {
            int a = 10;
            int b = 20;
            sum(a, b);

            object x = 1;//boxing<---
            int y =int.Parse(x.ToString());//unboxing

            dynamic no = 1;
            dynamic str = "hello";
            dynamic obj = new Student();

            obj.sjahdjagsdj = 10;//runtime
            int vv = no;//exception
            int vvv = str;//Exception
            no = str + obj;
        }
    }
}
