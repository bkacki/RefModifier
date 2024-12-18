namespace RefModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var guy = new Guy() { Name="Julian", Age=26 };
            Console.WriteLine("i to {0}, a guy to {1}", i, guy);
            ModifyAnIntAndGuy(ref i, ref guy);
            Console.WriteLine("Teraz i to {0}, a guy to {1}", i, guy);
        }

        static void ModifyAnIntAndGuy(ref int valueRef, ref Guy guyRef)
        {
            valueRef += 10;
            guyRef.Name = "Bogdan";
            guyRef.Age = 33;
        }
    }
}
