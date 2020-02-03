using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Upcasting,Downcasting
            //upcasting,implicit,boxing

            //object eagle3 = new Eagle();
            //object a = 5;
            //object word = "Mubush";
            //Console.WriteLine(eagle1.GetType());
            //Eagle eagle = new Eagle();
            //Bird eagle1 = new Eagle();



            //downcasting,explicit,unboxing
            //Animal eagle2 = new Eagle();
            //Animal shark = new Shark();

            //insecurity way
            //Shark sh = (Shark)eagle2;

            //security way-1
            //Shark sh = shark as Shark;
            //Console.WriteLine(sh==null);
            //Console.WriteLine(sh);


            //security way-2
            //if(shark is Shark)
            //{
            //    Shark sh = (Shark)shark;
            //    Console.WriteLine("downcasting");
            //}
            //else
            //{
            //    Console.WriteLine("Downcating ede bilmersiz");
            //}
            #endregion

            #region Implicit,Explicit
            //Manat manat = new Manat() { Azn=100};
            //Dollar dollar =(Dollar) manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region Operators for custom type
            //Person mubush = new Person("Mubariz", "Memmedzade", 20);
            //Person hemid = new Person("Hemid", "Qarayev", 19);

            //Eagle eagle1 = new Eagle();
            //Eagle eagle2 = new Eagle();

            //int age1 = 20;
            //int age2 = 19;
            //Console.WriteLine(age1>age2);
            //    Console.WriteLine(mubush>hemid);

            //    Console.WriteLine(mubush-hemid);
            //    Console.WriteLine(eagle1>eagle2);
            #endregion

            #region HomeWork
            Group p507 = new Group("P507");
            Group p508 = new Group("P508");

            Student stu1 = new Student("Mubariz", "Memmedzade");
            Student stu2 = new Student("Hemid", "Qarayev");
            Student stu3 = new Student("Ebulfet", "Memmedov");
            Student stu4 = new Student("Bakhtiyar", "Shamilzada");

            p507.AddStudent(stu1);
            p507.AddStudent(stu2);

            p508.AddStudent(stu3);
            p508.AddStudent(stu4);

            //p508.ShowAllStudents();

            //p508.ShowStudentById(5);

            p508.RemoveStudentById(4);

            p508.ShowAllStudents();

            #endregion

            //int[] x = { 1, 20, 30 };
            //int[,] y = { {26,56,23 }, {23,45,75 } };
            //Console.WriteLine(y[1,1]);
            int[,,] z = { { {1,2 }, {3,4 } }, { { 5,6}, {7,8 } } };
            Console.WriteLine(z[0,0,0]);
        }
    }

    #region Operators for custom type
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static bool operator >(Person p1,Person p2)
        {
            return p1.Name.Length > p2.Name.Length;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public static int operator -(Person p1, Person p2)
        {
            return p1.Age - p2.Age;
        }

        public static string operator +(Person p1, Person p2)
        {
            return p1.Name + p2.Name;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Name == p2.Name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Name != p2.Name;
        }
    }
    #endregion

    #region Implicit,Explicit
    //class Manat
    //{
    //    public int Azn { get; set; }

    //    //implicit method
    //    //public static implicit operator Dollar(Manat manat)
    //    //{
    //    //    return new Dollar { Usd = manat.Azn * 2 };
    //    //}


    //    //explicit
    //    public static explicit operator Dollar(Manat manat)
    //    {
    //        return new Dollar { Usd = manat.Azn * 2 };
    //    }
    //}

    //class Dollar
    //{
    //    public int Usd { get; set; }
    //}

    #endregion

    #region Upcasting,Downcasting
    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Shark : Fish
    {
        public int Kg { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }

    class Eagle : Bird
    {
        public double FlySpeed { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }
    #endregion

}
