namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1

            #region Question 1

            //Calculator calculator = new Calculator();
            //int result = calculator.Add(10, 20);
            //Console.WriteLine($"Result of adding 2 int numbers 10 + 20 = {result}");
            //Console.WriteLine("---------------------------------------------------");
            //result = calculator.Add(10, 20, 30);
            //Console.WriteLine($"Result of adding 3 int numbers 10 + 20 + 30 = {result}");
            //Console.WriteLine("---------------------------------------------------");
            //double sum = calculator.Add(1.2, 2.5);
            //Console.WriteLine($"Result of adding 2 double numbers 1.2 + 2.5 = {sum}");
            //Console.WriteLine("---------------------------------------------------");
            #endregion

            #region Question 2
            //Console.WriteLine("A parameterless constructor");
            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine(rectangle);
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("A constructor that accepts width and height as integers");
            //rectangle = new Rectangle(10,20);
            //Console.WriteLine(rectangle);
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("A constructor that accepts a single integer and sets both width and height to that value");
            //rectangle = new Rectangle(10);
            //Console.WriteLine(rectangle);
            #endregion

            #region Question 3
            //ComplexNumber c1 = new ComplexNumber()
            //{
            //    Real = 1,
            //    Imgine = 2,
            //};
            //ComplexNumber c2 = new ComplexNumber()
            //{
            //    Real = 2,
            //    Imgine = 3,
            //};
            //ComplexNumber? c3 = default;
            //c3 = c1 + c2;
            //Console.WriteLine(c3);
            #endregion

            #region Question 4
            //Employee employee = new Employee();
            //employee.Work();
            //Manager manager = new Manager();
            //manager.Work();
            #endregion

            #region Question 5
            //BaseClass baseobject = new BaseClass();
            //baseobject.DisplayMessage();
            ////Message from BaseClass
            //baseobject = new DerivedClass1();
            //baseobject.DisplayMessage();
            ////Message from DerivedClass1
            ////dynamic binding through run time--> run derived class
            //baseobject = new DerivedClass2();
            //baseobject.DisplayMessage();
            ////Message from BaseClass
            ////static binding through compile time --> run parent/base class


            #endregion
            #endregion

            #region part 2

            Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);

            D1 = new Duration(3600);
            //Console.WriteLine(D1);

            Duration D2 = new Duration(7800);
            //Console.WriteLine(D2);

            Duration D3 = new Duration(666);
            //Console.WriteLine(D3);

            //Console.WriteLine(D1);
            //Console.WriteLine(D2);
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine(D1 + D2);

            //Console.WriteLine(D1);
            //Console.WriteLine(new Duration(7800));
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine(D1 + 7800);


            //Console.WriteLine(D3);
            //Console.WriteLine(new Duration(666));
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine(666 + D3);

            //Console.WriteLine(D1);
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine(++D1);

            //Console.WriteLine(D1);
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine(--D1);

            //Console.WriteLine(D2);
            //Console.WriteLine(D1);
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine(D2-D1);

            //Console.WriteLine(D1);
            //Console.WriteLine(D2);
            //if (D1 > D2){
            //    Console.WriteLine("D1 is Greater than D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1 is Less than D2");

            //}

            //Console.WriteLine(D1);
            //Console.WriteLine(D2);
            //if (D1 <= D2)
            //{
            //    Console.WriteLine("D1 is Less than or equal D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1 is Greater than D2");

            //}

            //if (D1)
            //{
            //    Console.WriteLine("D1 is not null");
            //}
            //else {
            //    Console.WriteLine("D1 is null");
            //}

            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj);
            #endregion
        }
    }
    }
