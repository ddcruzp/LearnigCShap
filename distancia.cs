// using System; 
// using static System.Math;

// namespace Distancia
// {
//     class program
//     {
//         static void Main(string[] args)
//         {
            
//         //ejercicio 1:
//         //     Console.WriteLine("\nEntre la coordenada x del primer punto : ");
//         //     double x1 = double.Parse(Console.ReadLine());
//         //     Console.WriteLine("\nEntre la coordenada y del primer punto : ");
//         //     double y1 = double.Parse(Console.ReadLine());

//         //     Console.WriteLine("\nEntre la coordenada x del segundo punto : ");
//         //     double x2 = double.Parse(Console.ReadLine());
//         //     Console.WriteLine("\nEntre la coordenada y del segundo punto : ");
//         //     double y2 = double.Parse(Console.ReadLine());

//         //     Console.WriteLine("La distancia entre los dospuntos es {0}",Sqrt(Pow(x2 - x1 , 2) + Pow(y2 - y1 , 2)));

//         //ejercicio 2:
//         // Console.WriteLine("tecelee el primer lado del triangulo:");
//         // int a = int.Parse(Console.ReadLine());

//         // Console.WriteLine("tecelee el segundo lado del triangulo:");
//         // int b = int.Parse(Console.ReadLine());

//         // Console.WriteLine("tecelee el tercer lado del triangulo:");
     
//         // int c = int.Parse(Console.ReadLine());
     
//         // Console.WriteLine("El Triangulo es : {0}",TipoDelTriangulo(a,b,c));
        
//             // string [] input = System.Console.ReadLine().Split(' ');

//             // int a = int.Parse(input[0]) ;
           
//             // int b = int.Parse(input[2]) ;
           
//             // char op = input[1][0];
           
//             // foreach (var item in input)
//             // {
//             //     System.Console.WriteLine(item);
//             // }
//             // Console.WriteLine(Calcula(a,b,op));
        
//             // 
//             // Console.WriteLine("Teclee unnumero por favor:");
//             // int s = int.Parse(Console.ReadLine());
//             // if(Primo(s) == true)
//             // {
//             //     System.Console.WriteLine("El numero es primo");
//             // }
//             // else System.Console.WriteLine("El numero no es primo");
//             // int [] s = {3,43,34,34,54,65,76,87,3};
//             // Console.Write("Ingrese un numero por favor : ");
//             // var a = int.Parse(Console.ReadLine());
//             // Console.WriteLine("El inverso del numero tecleado es :" + InvertirNumero(a));

//             // Console.WriteLine("escribe tu nombre:");
//             // string s = Console.ReadLine();
//             // System.Console.WriteLine(Anagrama(s));

//             //Console.WriteLine(Anagrama(s));
//             // System.Console.WriteLine("El valor absoluto de dicho numero es : " + ValorAbsoluto(a));
//             // System.Console.WriteLine("Potencia : " + Math.Pow(a,3));
//             // System.Console.WriteLine("Raiz Cuadrada : " + Math.Sqrt(a));
//             // System.Console.WriteLine("Seno : " + Math.Sin(a*Math.PI/180));
//             // System.Console.WriteLine("Coseno : " + Math.Cos(a*Math.PI/180));
//             // System.Console.WriteLine("Numero maximo : " + Math.Max(a,50));
//             // System.Console.WriteLine("Numero minimo : " + Math.Min(a, 50));
//             // System.Console.WriteLine("Parte entera : " + Math.Truncate(5.64));
//             // System.Console.WriteLine("redondeo : " + Math.Round(5.67));

//            /* double BASE, ALTURA, RESUL;
//             string linea;
//             Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
//             BASE = double.Parse (linea);
//             Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
//             ALTURA= double.Parse (linea);
//             RESUL = (BASE * ALTURA) / 2;
//             System.Console.WriteLine("Area del triangulo" + String.Format("{0:#.0000}",RESUL));
//             System.Console.WriteLine("Area del triangulo" + String.Format("{0:c}",RESUL));
//             System.Console.WriteLine("Area del triangulo" + String.Format("{0:f}",RESUL));
//             System.Console.WriteLine("Area del triangulo" + String.Format("{0:g}",RESUL));*/

//             // int[] years = { 2013, 2014, 2015 };
//             // int[] population = { 1025632, 1105967, 1148203 };
//             // var sb = new System.Text.StringBuilder();
//             // sb.Append(String.Format("{0,6} {1,15}\n\n","Year","Population"));
//             // for(int index = 0 ; index < years.Length  ; index++)
//             //  sb.Append(String.Format("{0,6} {1,15:N0} \n",years[index], population[index]));

//             //  System.Console.WriteLine(sb);

//             // Tuple<string,DateTime,int,DateTime,int>[] cities = {Tuple.Create("New York",new DateTime(2017,1,30),3049393,new DateTime(2020,1,30),6059965),
//             //                                                     Tuple.Create("Detroit",new DateTime(2017,1,30),2777693,new DateTime(2020,1,30),4075489),
//             //                                                     Tuple.Create("Florida",new DateTime(2017,1,28),1777693,new DateTime(2020,1,30),3075489),
//             //                                                     Tuple.Create("Philadelphia",new DateTime(2017,1,15),2000093,new DateTime(2020,1,26),3455489),
//             //  };
//             //  var dates = String.Format("{0,12}{1,6}{2,12}{3,16}{2,12}{4,16}\n","City","Years","Population","3YearsLater","Change (%)");
//             // System.Console.WriteLine(dates);
//             // foreach(var city in cities){
//             //     var output = String.Format("{0,12}{1,6:yyyy}{2,12:N0}{3,16:yyyy}{4,12:N0}{5,15:P1}",city.Item1,city.Item2,city.Item3,city.Item4,city.Item5,(city.Item5 - city.Item3)/(double)city.Item3);
//             // System.Console.WriteLine(output);
//             // }


//             // string linea ="";
//             // System.Console.Write("Nombre del empleado: ");string s = Console.ReadLine();
//             // System.Console.Write("Salario : ");linea = System.Console.ReadLine();
//             // double a = double.Parse(linea);
//             // System.Console.Write("Cantidad de hijos del empleado : ");linea = System.Console.ReadLine();
//             // int b = int.Parse(linea);
//             // System.Console.WriteLine("El pago a recibir de {1} es : {0}" , String.Format("{0:c}",Arecibir(a,b)),s);


//             //System.Console.WriteLine("Hoy es"+ String.Format("{0:f}",DateTime.Now));
            
//             Console.Write("Cantidad de calculos :");string linea = Console.ReadLine();
//             byte CAN = byte.Parse(linea);
//             Console.Write("Dijite el total del presupuesto :");linea = Console.ReadLine();
//             double CANP = double.Parse(linea);
//             for(int I = 1; I <= CAN ; I++)
//             {
//                 Console.Write("Area de trabajo :"); string Area = Console.ReadLine();
//                 double  c = ZonaTrabajo(Area);
//                 double TOT = CANP * c/100;
//                 Console.WriteLine("El trabajador del area de {1} : {0}",String.Format("{0:C}",TOT),Area);
//             }
//             System.Console.WriteLine("Ya obtuvo su respuesta tenga buen dia.");


//         }
      
   
//         // }  

//         // static int Calcula(int op1, int op2, char operador)
//         // {
//         // switch (operador)
//         //    {
//         //     case '+':
//         //     return op1 + op2;
//         //     case '-':
//         //     return op1 - op2;
//         //     case '*':
//         //     return op1 * op2;
//         //     case '/':
//         //     return op1 / op2;
//         //     default:
//         //     throw new Exception("Operador incorrecto");
//         //    }
//         // }

//         // static string DecimalABinario(int n)
//         // {
//         //     string binario = "";
//         //     if (n == 0) return "0";
//         //     while (n > 0)
//         //     {
//         //         if (n % 2 == 0) binario = "0" + binario;
//         //         else binario = "1" + binario;
//         //         n = n / 2;
//         //     }
            
//         //     return binario;
//         // }

//         // static bool Primo(int n)
//         // {
//         //     int r = 2;
//         //     while (r < n)
//         //     {
//         //         if(n % r == 0) return false;
//         //         else r++;
//         //     }
//         //     return true;
//         // }

//         static int InvertirNumero(int a)
//         {
//             if((a<=99)&&(a>=1))
//             {
//                 var DEC = a/10;
//                 var UNI = a%10;
//                 return (UNI * 10) + DEC;
//             }
//             else if(a>= 100)
//             {
//                 var CEN = a/100;
//                 a = a%100;
//                 var DEC = a/10;
//                 var UNI = a%10; 
//                 return (UNI * 100) + (DEC * 10) + CEN;
//             }
//             return 0;
//         }
//         static long ValorAbsoluto(int a)
//         {
//             long result = Math.Abs(a);
//             return result;
//         }
//         static bool Anagrama(string a)
//         {
//             string reverse = "";
//             for (int i = a.Length -1; i >= 0; i--)
//             {
//                 reverse += a[i]; 
//             }
//             if(a == reverse)
//             {
//                 return true;
//             }
//             else return false;
//         }
//         static double Arecibir(double a,int b)
//         {
//             double bono = 0;
//             if((b < 3) && (b > 1))
//             {
//                 bono = b * 10;
//             }
//             else if(b >= 3)
//             {
//                 bono = b * 20;
//             }
//             return bono + a;
//         }
//         static double ZonaTrabajo(string a)
//         {
//             double b;
//             switch(a)
//             {
//                 case "Ginecologia": 
//                     b = 40;
//                     break;
//                 case "Traumatologia": 
//                     b = 30;
//                     break;
//                 case "Pediatria":
//                     b = 30;
//                     break;
//                 default:  
//                     b = 0;
//                     break;
//             }
//             return b;
//         }
//     }
// }