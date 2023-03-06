using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
          /*var opcion = MostrarMenu();

          while (opcion != "5")
          {
            EjecutarOpcion(opcion);
            opcion = MostrarMenu();
          }
          */
          Console.WriteLine("Ingrese moneda y luego valor");
          string moneda = Console.ReadLine();
          double valor = Convert.ToDouble(Console.ReadLine());

         Intercambio(moneda, valor);


        }
        
        public static void Intercambio(string moneda, double valor)
        {
          

          if(moneda == "dolar")
          {
            DolarEuro(valor);
          }else if(moneda == "euro")
          {
            EuroDolar(valor);
          }
            
          double DolarEuro(double valor)
          {
            double tasaEuro = 0.9398;
            double ConversionAEuro = valor * tasaEuro;
            Console.WriteLine(ConversionAEuro);
            return ConversionAEuro;
          }

          double EuroDolar(double valor)
          {
            double tasaDolar = 1.06397;
          double ConversionADolar = valor * tasaDolar;
          Console.WriteLine(ConversionADolar);
          return ConversionADolar;
          }

        }



        /*
        public static string MostrarMenu()
        {
          Console.WriteLine("**** Menu *****");
          Console.WriteLine("**** 1. Suma *****");
          Console.WriteLine("**** 2. Resta *****");
          Console.WriteLine("**** 3. Multiplicacion *****");
          Console.WriteLine("**** 4. Operacion *****");
          Console.WriteLine("**** 5. Salir *****");
          return Console.ReadLine();
          
        }

        public static void EjecutarOpcion(string opcion)
        {
          switch (opcion)
          {
            case "1":
            Console.WriteLine(Suma(1,7));
            break;
            case "2":
            Console.WriteLine(Resta(15,9));
            break;
            case "3":
            Console.WriteLine(Multiplicacion(10,3));
            break;
            case "4":
            Console.WriteLine(Operacion(5,2));
            break;
            default:
            break;

          }
        }
          
          public static int Suma(int n1, int n2)
          {
            return n1 + n2;
          }

            public static int Resta(int n1, int n2)
          {
            return n1 - n2;
          }

            public static int Multiplicacion(int n1, int n2)
          {
            return n1 * n2;
          }

            public static int Operacion(int n1, int n2)
          {
            var numeroSuma = Suma(n1, n2);
            var resta = Resta(numeroSuma, n2);
            var multiplicacion = Multiplicacion(numeroSuma, n2);

            return resta;
          }
          */
        




         
    }
}