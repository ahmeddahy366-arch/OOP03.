namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1

            //    Q1 Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?


            //Overloading → same name, different parameters.
            //Overriding → same method, different implementation in child clas

            //b)  What is the difference between Static Binding and Dynamic Binding?

            //static Binding ->Early Binding = Compile Time = Reference Type =overloading
            //dynamic Binding ->Late Binding = Run Time    = Actual Object = overriding
            #endregion
            #region question2

            //Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //    A sealed class cannot be inherited.

            //b)  What is the difference between a sealed class and a sealed method?
            //        A sealed class prevents inheritance, while a sealed method prevents further overriding of that method.


            //c)  Can a sealed method be overridden? Why?
            //No A sealed method cannot be overridden because sealed prevents further overriding in derived classes.
            #endregion

        }
    }
}
