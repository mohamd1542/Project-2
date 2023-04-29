namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /////OLD non-Generic way//////
           bool resalt = Equlator.AreEquale(10, 20);
           bool resalt1 = Equlator.AreEquale(10.5, 20.5);
           bool resalt2 = Equlator.AreEquale("AB", "AB");
           /////NEW Generic way/////
           bool isGenericResalt = GenericEqulator.AerEqual<double>(10, 20);

            /////Generic Class/////
            var First = new GenericClass<int>("ten","sdsdsds ds",10);
            Console.WriteLine($"{First.Item} : {First.Name} - {First.Description}");

            var genericlass = new LimitedGenericClass<ElementaryStudent>();

            var firstStudent = new ElementaryStudent() { Age = 10 , FullName = "Mohamd"};
            var secoundStudent = new ElementaryStudent() { Age = 8, FullName = "Mostafa" };

            genericlass.GenericMethod(firstStudent , secoundStudent);


            //if (resalt)
            //    Console.WriteLine("Both Numbers are equal");
            //else
            //    Console.WriteLine("Both Numbers are Not equal");
        }
    }
    public interface IStudents
    {

    }
    public class ElementaryStudent:IStudents
    {
        public int Age { get; set; }
        public string FullName { get; set; }
    }
 }