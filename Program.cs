using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labdisc {
    class Program { 
        static void Main (string[] args) {
            do {
                double a=0, b=0, c=0;
                Console.WriteLine("Ввод коэффицента a квадратного уравнения:");
                Program.check_exs(out a);
                Console.WriteLine("Ввод коэффицента b квадратного уравнения:");
                Program.check_exs(out b);
                Console.WriteLine("Ввод коэффицента с квадратного уравнения:");
                Program.check_exs(out c);
                double x1=0, x2=0, D=0;
                Console.WriteLine("D = "+(D=b*b-4*a*c));
                if (D>0) {
                    x1=((-b-Math.Sqrt(D))/2/a);
                    x2=((-b+Math.Sqrt(D))/2/a);
                    Console.WriteLine("Корни квадратного уравнения: x1="+x1+" x2="+x2);
                }
                else if (D==0) {Console.WriteLine("Корень квадратного уравнения: x="+(-b/2/a));}
                else {Console.WriteLine("У квадратного уравнения не существует корней.");}
                Console.WriteLine("Хотите решить ещё одно уравние (да/нет):");
            } while (Program.again() == true);
        }
        static bool again() {
            string enter = Console.ReadLine();
            if (enter == "да") return true;
            else return false;
            }
        static void check_exs (out double t) {
            bool w; t=0;
             do {
                w=false;
                string enter=Console.ReadLine();
                try {t=double.Parse(enter);}
                catch (Exception) {
                    Console.WriteLine("Введен недопустимый коэффицент уравнения. Повторите ввод: ");
                    w=true;
                }
            }
            while (w==true);
        } 
    }
}

