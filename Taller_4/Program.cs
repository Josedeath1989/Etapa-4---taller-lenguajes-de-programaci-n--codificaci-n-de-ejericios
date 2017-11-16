/*Nombre del Autor: Jose Luis Sierra Ramirez
Fecha: 13_11_2017
Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi 
trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar*/ 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, exit = 0;
            // Bucle para manejar la salida del programa
            while (exit == 0)
            {
                Borrar();
            
            //Se llama la funcion creada para generar el marco y la decoracion 
            Cuadro(1, 1, 100, 30);
            Cuadro(8, 8, 93, 29);
            Borrar();
            Mensaje("TALLER DE LENGUAJE DE PROGRAMACION", 2, 1);
            Mensaje("Nombre del autor: Jose Luis Sierra Ramirez", 10, 3);
            Mensaje("Fecha: 13 de noviembre del 2017", 10, 4);
            Mensaje("Doy fe que este ejercicio es de mi autoría.", 10, 5);
            Mensaje("MENU PRINCIPAL", 12, 8);
            Mensaje("1...Ejercicio #1", 12, 10);
            Mensaje("2...Ejercicio #2", 12, 11);
            Mensaje("3...Ejercicio #3", 12, 12);
            Mensaje("4...Ejercicio #4", 12, 13);
            Mensaje("5...Ejercicio #5", 12, 14);
            Mensaje("6...Ejercicio #6", 12, 15);
            Mensaje("7...Ejercicio #7", 12, 16);
            Mensaje("8...Ejercicio #8", 12, 17);
            Mensaje("9...Ejercicio #9", 12, 18);
            Mensaje("10...Ejercicio #10", 12, 19);
            Mensaje("11...Ejercicio #11", 12, 20);
            Mensaje("12...Ejercicio #12", 12, 21);
            Mensaje("13...Ejercicio #13", 12, 22);
            Mensaje("14...Ejercicio #14", 12, 23);
            Mensaje("...............OPRIMA EL NUMERO 1 PARA SALIR.................", 20, 27);
            Mensaje("...............JOSE LUIS SIERRA RAMIREZ.................", 20, 30);
            Mensaje("ELIGA UNA OPCION DEL MENU: ", 20, 25);

            op = int.Parse(Console.ReadLine());

            //Estructura donde validadmos la opcion y llamamos las otras funciones de los subprogramas
            switch (op)
            {
                case 1:
                    Borrar();
                    Mensaje(" Ejercicio #1 ", 12, 8);
                    Mensaje("Digite el primer digito de la contraseña ", 12, 10);
                    int cont1 = int.Parse(Console.ReadLine());
                    Mensaje("Digite el segunda digito de la contraseña ", 12, 11);
                    int cont2 = int.Parse(Console.ReadLine());
                    Mensaje("Digite el tercera digito de la contraseña ", 12, 12);
                    int cont3 = int.Parse(Console.ReadLine());
                    Mensaje("Digite el Cuarto digito de la contraseña ", 12, 13);
                    int cont4 = int.Parse(Console.ReadLine());
                    Ejer1(contra1: cont1, contra2: cont2, contra3: cont3, contra4: cont4);
                    break;
                case 2:
                    Borrar();
                    Mensaje(" Ejercicio #2 ", 12, 8);
                    int a = 0, m = 0, d = 0;
                    Mensaje("Digite el año: ", 12, 10);
                    a = int.Parse(Console.ReadLine());
                    Mensaje("Digite el mes: ", 12, 11);
                    m = int.Parse(Console.ReadLine());
                    Mensaje("Digite el dia: ", 12, 12);
                    d = int.Parse(Console.ReadLine());
                    Ejer2(aa: a, mm: m, dd: d);
                    break;
                case 3:
                    Borrar();
                    Mensaje(" Ejercicio #3 ", 12, 8);
                    Mensaje(" Digite un mumero ", 12, 10);
                    string numero = Console.ReadLine();
                    ejer3(num:numero);
                    break;
                case 4:
                    Borrar();
                    Mensaje("Ejercicio #4", 12, 8);
                    Mensaje("Digite el numero de horas trabajadas: ", 12, 10);
                    int horas = int.Parse(Console.ReadLine());
                    Mensaje("Digite la cantidad de dias trabajados al mes: ", 12, 11);
                    int dias = int.Parse(Console.ReadLine());
                    Mensaje("Digite la categoria. ", 12, 12);
                    int categoria = int.Parse(Console.ReadLine());
                    ejer4(h: horas, d: dias, c: categoria);
                    break;
                case 5:
                    Borrar();
                    Mensaje("Ejercicio #5", 12, 8);
                    Mensaje("Ingreso el nombre del usuario: ", 12, 10);
                    string n = Console.ReadLine();
                    Mensaje("Ingrese la contaseña a utilizar para el usuario: ", 12, 11);
                    string co = Console.ReadLine();
                    Mensaje("________________________________________________", 12, 12);
                    Mensaje("Digite el Usudario: ", 12, 13);
                    string u = Console.ReadLine();
                    Mensaje("Digite la contraseña: ", 12 ,14);
                    string pass = Console.ReadLine();
                    ejer5(nombre:n, contraseña:co, usu:u, pas:pass);
                    break;
                case 6:
                    Borrar();
                    Mensaje("Ejercicio #6", 12, 8);
                    Mensaje("Digite un numero: ",12,10);
                    int par = int.Parse(Console.ReadLine());
                    Mensaje("__________________", 12, 11);
                    ejer6(p:par);
                    break;
                case 7:
                    Borrar();
                    Mensaje("Ejercicio #7", 12, 8);
                    Mensaje("Digite el lado A: ", 12, 10);
                    int a1 = int.Parse(Console.ReadLine());
                    Mensaje("Digite el lado B: ", 12, 11);
                    int b1 = int.Parse(Console.ReadLine());
                    Mensaje("Digite el lado C: ", 12, 12);
                    int c1 = int.Parse(Console.ReadLine());
                    Mensaje("_____________________________", 12, 13);
                    ejer7(A:a1, B:b1, C:c1);
                    break;
                case 8:
                    Borrar();
                    Mensaje("Ejercicio #8", 12, 8);
                    Mensaje("Digite el nombre del aspirante: ",12, 10);
                    string nomb = Console.ReadLine();
                    Mensaje("Digite su edad: ", 12, 12);
                    int ed = int.Parse(Console.ReadLine());
                    Mensaje("Eres profecional 1 para SI 2 para NO: ", 12, 12);
                    int des = int.Parse(Console.ReadLine());
                    ejer8(NOMB:nomb, ED:ed, DES:des);
                    break;
                case 9:
                    Borrar();
                    Mensaje("Ejercicio #9", 12, 8);
                    Mensaje("Digite el valor en centigrados a convertir: ", 12, 10);
                    int cen = int.Parse(Console.ReadLine());
                    Mensaje("____________________________________________", 12, 11);
                    ejer9(CEN:cen);
                    break;
                case 10:
                    Borrar();
                    Mensaje("Ejercicio #11", 12, 8);
                    Mensaje("Por fvor digite el medida del galo: ", 12, 10);
                    int gal = int.Parse(Console.ReadLine());
                    Mensaje("Por fvor digite el medida del barril: ", 12, 11);
                    int bar = int.Parse(Console.ReadLine());
                    Mensaje("________________________________________ ", 12, 12);
                    ejer10(GAL:gal, BAR:bar);
                    break;
                case 11:
                    Borrar();
                    Mensaje("Ejercicio #11", 12, 8);
                    Mensaje("Digite el radio del cilindro para calcular su Area: ", 12, 10);
                    int rad = int.Parse(Console.ReadLine());
                    Mensaje("_____________________________________________________", 12, 11);
                    ejer11(RAD:rad);
                    break;
                case 12:
                    Borrar();
                    Mensaje("Ejercicio #12", 12, 8);
                    Mensaje("Digite un numero entero para sacarle la potencia: ", 12, 10);
                    int np = int.Parse(Console.ReadLine());
                    Mensaje("__________________________________________________", 12, 11);
                    ejer12(NP:np);
                    break;
                case 13:
                    break;
                case 14:
                    break;
                default:
                    Mensaje("Opcion incorrecta", 0, 0);
                    break;


            }
                
              Mensaje("Digite 0 para ir la menu Digite 1 para salir", 12,19);
                exit = int.Parse(Console.ReadLine());

                if (exit == 1)
                {
                    exit = 1;
                    Mensaje("!!!!!!!!!!!!!!Esto fue todo!!!!!!!!!!!!!!!!!!!", 12, 20);
                }
                else
                {
                    exit = 0;
                }

              Console.ReadKey();
            }
        }
        //******Metodo de Ejercicio #1***//
        static void Ejer1(int contra1, int contra2, int contra3, int contra4)
        {
            Cuadro(8, 8, 93, 29);
            System.Console.SetCursorPosition(12, 17);
            Console.Write("{0}La contraseña encryptada es: ");
            Console.Write(contra4);
            Console.Write(contra3);
            Console.Write(contra2);
            Console.Write(contra1);
        }
        //******Metodo de Ejercicio #2***//
        static void Ejer2(int aa, int mm, int dd)
        {
            Cuadro(8, 8, 93, 29);
            int dias, mes, año;
            if ((dd > 30 && (mm == 2 || mm == 6 || mm == 9 || mm == 11)) || (dd > 29 && mm ==2) || (dd > 28 && mm == 2 && ((aa % 4 != 0) || (aa % 100) == 0 ) && (aa % 400) != 0 ) || (dd > 31 ))
            {
                System.Console.SetCursorPosition(12, 14);
                Console.Write("Estas mal ");
            }
            else
            {
                if ((dd > 30 && (mm == 2 || mm == 6 || mm == 9 || mm == 11)) || (dd == 29 && mm == 2) || (dd > 28 && mm == 2 && ((aa % 4 != 0) || (aa % 100) == 0) && (aa % 400) != 0) || (dd > 31))
                {
                    dias = 0;
                    mes = mm + 1;
                }
                else
                {
                    dias = dd + 1;
                    mes = mm;
                }
                if(dias == 0 && mes == 12 )
                {
                    mes = 1;
                    año = aa + 1;
                }
                else
                {
                    año = aa;
                }
                System.Console.SetCursorPosition(12, 14);
                Console.WriteLine("La fecha del dia siguiente"+dias);
                System.Console.SetCursorPosition(12, 15);
                Console.WriteLine("La fecha del mes siguiente" + mes);
                System.Console.SetCursorPosition(12, 16);
                Console.WriteLine("La fecha del año siguiente" + año);

            }
        }
        //******Metodo de Ejercicio #3***//
        static void ejer3(string num)
        {
            Cuadro(8, 8, 93, 29);
            string aux = "";
            bool bol = false;
            if(num.Length >3 || num.Length <3 )
            {
                System.Console.SetCursorPosition(12, 12);
                Console.WriteLine("No se admiten munero mayores o menores a tres digitos");
            }
            else
            {
           
            for (int i = 0; i < num.Length; i++ )
            {
                aux = num.Substring(i, 1) + aux;
            }
            if(aux == num)
            {
                bol = true;
            }
                System.Console.SetCursorPosition(12, 12);
                Console.WriteLine("El Numero es capicuo: " + bol);
            }
            
        }
        //******Metodo de Ejercicio #4***//
        static void ejer4(int h, int d, int c)
        {
            Cuadro(8, 8, 93, 29);
            int th;
            double st, salud, t;

            if((h > 12 || h < 4) || (d > 31))
            {
                System.Console.SetCursorPosition(12, 13);
                Console.WriteLine("Numero de horas y dias no aspetadas");
           
            }
            else
            {
                th = h * d;

                if (c == 1)
                {
                    st = th * 20.000;
                    if(st < 1.000000)
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                        t = t - ((t * 15) / 100);
                    }else
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                    }
                    System.Console.SetCursorPosition(12, 13);
                    Console.WriteLine("El total a pagar es: " + t);
                }
                else if (c == 2)
                {
                    st = th * 15.000;
                    if (st < 1.000000)
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                        t = t - ((t * 15) / 100);
                    }
                    else
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                    }
                    System.Console.SetCursorPosition(12, 13);
                    Console.WriteLine("El total a pagar es: " + t);
                }
                else if (c == 3)
                {
                    st = th * 10.000;
                    if (st < 1.000000)
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                        t = t - ((t * 15) / 100);
                    }
                    else
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                    }
                    System.Console.SetCursorPosition(12, 13);
                    Console.WriteLine("El total a pagar es: " + t);
                }
                else if (c == 4)
                {
                    st = th * 7.500;
                    if (st < 1.000000)
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                        t = t - ((t * 15) / 100);
                    }
                    else
                    {
                        salud = (st * 7.2) / 100;
                        t = st - salud;
                    }
                    System.Console.SetCursorPosition(12, 13);
                    Console.WriteLine("El total a pagar es: " + t);

                }
                else
                {
                    System.Console.SetCursorPosition(12, 13);
                    Console.WriteLine("Categoria no valida");
                }
             
            }
         
        }
        //******Metodo de Ejercicio #5***//
        static void ejer5(string nombre, string contraseña, string usu, string pas)
        {
            Cuadro(8, 8, 93, 29);

            if(nombre == usu)
            {
                if(contraseña == pas)
                {
                    System.Console.SetCursorPosition(12, 15);
                    Console.WriteLine("Bienvenido");
                }else
                {
                    System.Console.SetCursorPosition(12, 15);
                    Console.WriteLine("Contraeña incorrecta");
                }
            }else
            {
                System.Console.SetCursorPosition(12, 15);
                Console.WriteLine("Usuario oncorrecto");
            }
            
        }
        //******Metodo de Ejercicio #6***//
        static void ejer6(int p)
        {
            Cuadro(8, 8, 93, 29);

            if(p % 1 == p || p % p == 1)
            {
                System.Console.SetCursorPosition(12, 12);
                Console.WriteLine("El numero es primo");
            }else
            {
                System.Console.SetCursorPosition(12, 12);
                Console.WriteLine("El numero no es primo");
            }
            
        }
        //******Metodo de Ejercicio #7***//
        static void ejer7(int A, int B, int C)
        {
            Cuadro(8, 8, 93, 29);
            if(A == B && B == C)
            {
                System.Console.SetCursorPosition(12, 14);
                Console.WriteLine("Equilatero");
            }else
            {
                if(A == B || A == C || B == C)
                {
                    System.Console.SetCursorPosition(12, 14);
                    Console.WriteLine("ISOCELES");
                }
                else
                {
                    System.Console.SetCursorPosition(12, 14);
                    Console.WriteLine("ESCALENO");
                }
            }
            
        }
        //******Metodo de Ejercicio #8***//
        static void ejer8(string NOMB, int ED, int DES)
        {
            Cuadro(8, 8, 93, 29);

            if(ED < 18)
            {
                System.Console.SetCursorPosition(12, 14);
                Console.WriteLine("No tienes la edad suficiente");
            }else
            {
                if(DES == 1)
                {
                    System.Console.SetCursorPosition(12, 14);
                    Console.WriteLine("Aceptado para la Vacante");
                }else
                {
                    System.Console.SetCursorPosition(12, 14);
                    Console.WriteLine("Te Falta el titulo de prrfesional");
                }
            }
            
        }
        //******Metodo de Ejercicio #9***//
        static void ejer9(int CEN)
        {
            Cuadro(8, 8, 93, 29);
            double far, kel;

            far = (CEN * 1.8) + 32;
            kel = CEN + 273.15;

            System.Console.SetCursorPosition(12, 12);
            Console.WriteLine("La conversion de centigrados a farenheim es: "+far);
            System.Console.SetCursorPosition(12, 13);
            Console.WriteLine("La conversin de centigrados a kelvin es : "+kel);
        }
        //******Metodo de Ejercicio #10***//
        static void ejer10(double GAL, double BAR)
        {
            double lit, lit1;
            Cuadro(8, 8, 93, 29);
            lit = GAL * 3.7854118;
            lit1 = BAR * 158.9873;

            System.Console.SetCursorPosition(12, 13);
            Console.WriteLine("La conversion de Galones a litros es: " + lit);
            System.Console.SetCursorPosition(12, 14);
            Console.WriteLine("La conversin de Barriles a Litros es : " + lit1);
        }
        //******Metodo de Ejercicio #11***//
        static void ejer11(double RAD)
        {
            Cuadro(8, 8, 93, 29);
            double area = 2 * 3.14 * RAD;
            System.Console.SetCursorPosition(12, 13);
            Console.WriteLine("El area del Cilindro es : " + area);
        }
        //******Metodo de Ejercicio #12***//
        static void ejer12(int NP)
        {
            Cuadro(8, 8, 93, 29);
            int oper = 0, res = 0;

            oper = NP % 2;

            if(oper == 0)
            {
                res = NP ^ 2;
            }else
            {
                System.Console.SetCursorPosition(12, 13);
                Console.WriteLine("!!!!El numero no es Entero!!!!!!! ");
            }
            System.Console.SetCursorPosition(12, 13);
            Console.WriteLine("El resultado de la potenciacion es: " + res);
        }
        //******Metodo de Ejercicio #13***//
        static void ejer13()
        {
            Cuadro(8, 8, 93, 29);
            Mensaje("Ejercicio #13", 12, 8);
        }
        //******Metodo de Ejercicio #14***//
        static void ejer14()
        {
            Cuadro(8, 8, 93, 29);
            Mensaje("Ejercicio #14", 12, 8);
        }
        //******Metodo Borrar contenido******//
        static void Borrar()
        {
            Mensaje("                                             ", 12, 10);
            Mensaje("                                             ", 12, 11);
            Mensaje("                                             ", 12, 12);
            Mensaje("                                             ", 12, 13);
            Mensaje("                                             ", 12, 14);
            Mensaje("                                             ", 12, 15);
            Mensaje("                                             ", 12, 16);
            Mensaje("                                             ", 12, 17);
            Mensaje("                                             ", 12, 18);
            Mensaje("                                             ", 12, 19);
            Mensaje("                                             ", 12, 20);
            Mensaje("                                             ", 12, 21);
            Mensaje("                                             ", 12, 22);
            Mensaje("                                             ", 12, 23);

        }
        //******Metodo de mesajeria******//
        static void Mensaje(string texto, int x, int y)
        {
            System.Console.SetCursorPosition(x, y);
            Console.Write(texto);
        }
        //******Metodo decoracion de Menu Maquetado cuado******//
        static void Cuadro(int x, int y, int x1, int y1)
        {
            int i, j;

            for (i = x; i <= x1; i++)
            {
                System.Console.SetCursorPosition(i, y);
                Console.Write("═");
                System.Console.SetCursorPosition(i, y1);
                Console.Write("═");
            }
            for (j = y; j <= y1; j++)
            {
                System.Console.SetCursorPosition(x, j);
                Console.Write("║");
                System.Console.SetCursorPosition(x1, j);
                Console.Write("║");
            }
            //SE CUADRAN LAS ESQUINAS DEL MARCO
            System.Console.SetCursorPosition(x1, y);
            Console.Write("╗");
            System.Console.SetCursorPosition(y, x);
            Console.Write("╔");
            System.Console.SetCursorPosition(x, y1);
            Console.Write("╚");
            System.Console.SetCursorPosition(x1, y1);
            Console.Write("╝");
        }

    }
}
 

    


