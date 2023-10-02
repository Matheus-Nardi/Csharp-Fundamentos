namespace TimeZone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utc pega uma data universal , sem fusos ex : +1 -3 
            var dataTime = DateTime.UtcNow;

            Console.WriteLine(dataTime);


            //Utc para outros países 

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dataTime, timeZoneAustralia);
            Console.WriteLine(horaAustralia);

            //Obter os Id 

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
                foreach(var timeZone in timeZones)
            {
                Console.WriteLine(timeZone.Id);
                Console.WriteLine(timeZone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataTime , timeZone));
                Console.WriteLine("---------------------------------");
            }

            Console.ReadLine() ;
        }
    }
}