namespace TVRemote
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tv = TVRemote.GetDevice();
            Tv.On();

        }
    }
}
