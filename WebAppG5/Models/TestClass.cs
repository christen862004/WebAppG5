namespace WebAppG5.Models
{
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
