using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

//tipos variables csharp
int n1 = 10;

int n2 = 20;

int rs = n1+n2;

string name = "Jesus";

double  numberD = 10.15;

bool quezada = true;
bool gonzales = false;

long cifra = 2,170;

char falso = 0;

Console.WriteLine("El resultado es: "+rs);

//captura de datos con enteros en csharp

Console.WriteLine("ingrese un numero: ");
int read;
read = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El numero ingresado fue: "+read);

//captura de datos con Strings en csharp

Console.WriteLine("Ingrese su nombre: ");

string rdname = Console.ReadLine();

Console.WriteLine("El nombre ingresado fue: "+rdname);


//casteo de variables en csharp

int myInt = 20;
double MyDouble = 5.25;
bool MyBool = true;

Console.WriteLine(Convert.ToString(MyInt)); //convertir de entero a string
Console.WriteLine(Convert.ToDouble(MyInt)); //convertir de decimal a entero
Console.WriteLine(Convert.ToInt32(MyDouble)); //convertir entero a decimal
Console.WriteLine(Convert.ToString(MyBool)); //convertir el booleano a stirng

//condicionales en csharp

if(read<=0){

Console.WriteLine("El numero es negativo");

} else{
  Console.WriteLine("el numero es positivo");
}



  }
}