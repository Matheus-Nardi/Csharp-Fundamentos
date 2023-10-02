namespace FormatandoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var data = DateTime.Now;
            //Y ano 
            //M mes
            //d dia 
            //h hora
            // m minuto
            // s segundo
            // z time Zone

            var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss  zz }", data);
            Console.Write(formatada);

            //d short day
            //t short time
            //g junta short
            var formatada1 = String.Format("{0:g}", data);
            Console.WriteLine(formatada1);


            //D long day
            //T long time
            // f junta long 
            var formatada2 = String.Format("{0:f}", data);
            Console.WriteLine(formatada2);



            // r padrao
            // s 
            // u padrao universal
            var formatada3= String.Format("{0:r}", data);
            var formatada4= String.Format("{0:u}", data);
            var formatada5= String.Format("{0:s}", data);
            Console.WriteLine(formatada3);
            Console.WriteLine(formatada4);
            Console.WriteLine(formatada5);


            Console.ReadLine();
        }
    }
}