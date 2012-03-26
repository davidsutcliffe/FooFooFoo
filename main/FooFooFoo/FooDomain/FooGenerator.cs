namespace FooDomain
{
    public class FooGenerator
    {
        public string GetFoo(int fooId)
        {
            switch (fooId)
            {
                case 1:
                    return "a";
                case 2:
                    return "b"; 
                case 3:
                    return "c";
                default:
                    return "z";
            }
        }
    }
}
