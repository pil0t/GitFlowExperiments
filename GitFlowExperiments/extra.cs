using System;

namespace ConsoleApp21
{

    public class TestMe
    {
        public Foo MyProperty { get; set; } = new Foo();
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
    }

    public class Bar
    {
        public void DoSomething()
        {
            Console.WriteLine("I am BAR");
        }
    }
}
