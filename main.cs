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

long cifra = 220;

char inicial = 'J';

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

int MyInt = 20;
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

//operadores paralelos

int a = 100+125;
int b = 250+a;
int c = a+a;

Console.WriteLine("Un resultado paralelo es: "+b);

Console.WriteLine("Suma de la misma variable 2 veces: "+c);

// agregar valor a una variable

int d = 18;
d +=2;
Console.WriteLine(d);

// ejercicio logico 1, determinar si los numeros son iguales

Console.WriteLine("Ingresa un numero: ");
int l1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresa otro numero: ");
int l2 = Convert.ToInt32(Console.ReadLine());


if(l1!=l2){
  Console.WriteLine("Los numeros no son iguales");
}else{
  Console.WriteLine("Los numeros son iguales");
}

//ejercicio 2, sistema de contraseñas

int psswd = 1001;

Console.WriteLine("Ingrese su contraseña para acceder al sistema");
int gt = Convert.ToInt32(Console.ReadLine());


if(gt!=psswd){
  Console.WriteLine("Contraseña incorrecta, intente de nuevo"); 
}else{
Console.WriteLine("Contraseña correcta, bienvenid@ al sistema");
}

//ejercicio 2, string a entero

/*Console.WriteLine("Ingrese una palabra: ");
int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("la palabra tiene: "+q+" caracteres");*/ //metodo incorrecto

string cadena = " Jesus"; //debemos dejar un espacio para que nos cuente desde ese espacio
string proceso = cadena.Split(' ')[1];
int cantidad = proceso.Length;

Console.WriteLine("La cantidad de caracteres que tiene:"+cadena+" es: "+cantidad);

//ahora el ejercicio a traves de la consola

string storage="/";

Console.WriteLine("Ingrese un nombre bandido: ");
storage = Console.ReadLine();

string prc = storage.Split('/')[0];
int tt = prc.Length;

Console.WriteLine(storage+" tiene "+tt+" caracteres");

//detectar que tipo de palabra es segun su numero de palabras
if(tt<=1){
  Console.WriteLine("La palabra es monosilaba");
}else if(tt<=2){
  Console.WriteLine("La palabra es bisilaba");
}else if(tt<=3){
  Console.WriteLine("La palabra es trisilaba");
}else if(tt<=4){
  Console.WriteLine("La palabra es cuatrisilaba");
}else if(tt>5){
  Console.WriteLine("La palabra tiene mas de 5 silabas, por lo cual puede ser pentasilaba, hexasilaba, heptasilaba u octosilaba");
}

  }
}