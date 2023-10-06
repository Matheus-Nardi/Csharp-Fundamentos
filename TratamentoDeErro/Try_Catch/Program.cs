namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Execption = erro / execção 


            var nums = new int[3];


            // Tente executar esse bloco
            try
            {
                //for(int i = 0; i < 10; i++) 
                //{
                //    Console.WriteLine(nums[i]);
                //}
            Salvar("Olá Mundo");
            

            }

            // Aqui o tratamento do erro e utilize a exeção dentro do parametro
            // Sempre do erro mais especifíco para o máis genérico

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Indice não encontrado no array");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("PRENCHA OS CAMPOS");
                Console.WriteLine(e.InnerException);
               
            }   catch (MinhaExecption e)
            {
                Console.WriteLine("MEU TRATAMENTO CUSTOMIZADO");
                Console.WriteLine(e.QuandoOcorreu);
               
            } catch (Exception e)
            {
                Console.WriteLine("ERRO");
                Console.WriteLine(e.Message);
               
            }
            finally // Garante o fim do fluxo , tanto se passar pelo catch ou não
            {
                Console.WriteLine("Fim");
            }

            //Boa prática é dividir os tratamento em blocos , não inserir todo o código dentro de um bloco apenas

            Console.ReadLine();
        }

        static void Salvar(string texto)
        {
            if(string.IsNullOrEmpty(texto))
            {
                throw new MinhaExecption(DateTime.Now);
            }
        }
    }

    public class MinhaExecption : Exception
    {
        
        public MinhaExecption(DateTime data) { QuandoOcorreu = data; }
        public DateTime QuandoOcorreu { get; set; }

    }

}