using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Principal
    {
        public static void Main(String[] Espartan)
        {

            int op,b,a,l, seguir;
            string c= "";
            Variable p = new Variable();
           
                    do
                    { 
                    Console.WriteLine("///////////////////////////////////////////////");
                    Console.WriteLine("//////CALCULO DE AREAS FORMAS GEOMETRICAS//////");
                    Console.WriteLine("//////////////////////////////////////////////");
            

                        op = p.validar(Console.WriteLine("1) Area del triangulo: \n2) Area del Rectangulo: \n3) Area del cuadrado: \nSeleccione una opcion: \n"));
                        op = Convert.ToInt32(Console.ReadLine());
                        p.Parea(op);
                        if (p.MArea() < 1 || p.MArea() > 3) { Console.WriteLine("Error, digite un valor valido"); 
                    } while (p.MArea() < 1 || p.MArea() > 3);
                

                   switch (op)
                              {
                        case 1:
                            
                            Console.WriteLine("/////////////////////////////");
                            Console.WriteLine("/////Area del triangulo/////");
                            Console.WriteLine("///////////////////////////");

                            do {
                                Console.WriteLine("Digite la base del triangulo: ");
                                b = Convert.ToInt32(Console.ReadLine());
                                if (b <= 0) { Console.WriteLine("La base no puede ser negativa"); }
                            } while (b <= 0);

                            do{
                                
                                Console.WriteLine("Digite la altura del triangulo: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a <= 0) { Console.WriteLine("La altura no puede ser negativa"); }
                            } while (a <= 0);

                            Console.WriteLine("El Area del triangulo es: " + p.calcularT(b, a));
                        
                            break;
                        case 2:
                     
                            Console.WriteLine("//////////////////////////////");
                            Console.WriteLine("/////Area del Rectangulo/////");
                            Console.WriteLine("/////////////////////////////");
                            do
                            {
                                Console.WriteLine("Digite la base del rectangulo: ");
                                b = Convert.ToInt32(Console.ReadLine());
                                if (b <= 0) { Console.WriteLine("La base no puede ser negativa"); }
                            } while (b <= 0);

                            do
                            {
                                Console.WriteLine("Digite la altura del rectangulo: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a <= 0) { Console.WriteLine("La altura no puede ser negativa"); }
                            } while (a <= 0);

                            Console.WriteLine("El Area del triangulo es: " + p.calcularR(b, a));
                       
                    break;
                        case 3:
                    
                            Console.WriteLine("//////////////////////////////");
                            Console.WriteLine("/////Area del Cuadrado/////");
                            Console.WriteLine("/////////////////////////////");
                            do
                            {
                                Console.WriteLine("Digite la logitud de un lado del Cuadrado: ");
                                l = Convert.ToInt32(Console.ReadLine());
                                if (l <= 0) { Console.WriteLine("La base no puede ser negativa"); }
                            } while (l <= 0);


                            Console.WriteLine("El Area del triangulo es: " + p.calcularC(l));
                       
                    break;
                    }
                    do
                    {
                        Console.WriteLine("Desea seguir en el programa? 1.Si 2.No: ");
                        seguir = Convert.ToInt32(Console.ReadLine());
                        if (seguir <= 0 || seguir > 2) { Console.WriteLine("Error, seleccione una opcion valida"); }
                    } while (seguir <= 0 || seguir > 2);

               
           
            

            Console.WriteLine("Fin del programa, t amo josthim<3");
        }
            
    }
}
