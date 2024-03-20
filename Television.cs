namespace TVRemote
{
    public class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            System.Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            System.Console.WriteLine("The TV is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            System.Console.WriteLine($"The TV volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            System.Console.WriteLine($"The TV volume is at {Volume}");
        }
    }
}