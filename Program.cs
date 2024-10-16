namespace GenericStackAssessment5
{
    public class GenericStack
    {
        static void Main(string[] args)
        {
            Stack<string> elements = new Stack<string>();
            elements.Push("Ash");
            elements.Push("pooja");
            elements.Push("sonyyyy");

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            elements.Peek();
            Console.WriteLine("display array elements:");
            elements.Pop();

            Console.WriteLine("after popping elements:");

            foreach(var element in elements)
            {
                Console.WriteLine(element);
            }


        }
    }
}
