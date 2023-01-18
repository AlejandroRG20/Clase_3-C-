using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Variable{
        private int area;

        public void Parea(int area)
        {
            this.area = area;
        }
        public int MArea()
        {
            return this.area;
        }
        public int calcularT(int b, int altura){
            
        return (b * altura) / 2; 
        }
        public int calcularR(int b, int altura)
        {

            return b * altura;
        }

        public int calcularC(int l)
        {

            return l*l;
        }
        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("No se aceptan letras", error.Message);
                }
            } while (v == 0);
            return num;
        }

    }
}
