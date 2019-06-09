using System;

namespace ConsoleApp21
{

    public class TestMe
    {
        public Foo MyProperty { get; set; } = new Foo();

        public void Do(string s)
        {
            Console.WriteLine("AAAA");
        }
        public void Do(Foo s)
        {
            Console.WriteLine("BBBB");
        }
    }


    public class Foo
    {
        public void DoSomething()
        {
            Console.WriteLine("I am FOO");
        }
        public static implicit operator Bar(Foo source)
        {
            return new Bar();
        }
        public static implicit operator string(Foo source)
        {
            return "test my string";
        }
        public static string operator +(Foo a, string b)

        {
            return "surprize!";
        }
        public static string operator +(string b, Foo a)

        {
            return "surprize!";
        }
    }

    public class Bar
    {
        public void DoSomething()
        {
            Console.WriteLine("I am BAR");
        }
    }
}
