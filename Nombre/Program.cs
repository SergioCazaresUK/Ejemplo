//string nombre = "Coca";
//if (string.IsNullOrWhiteSpace(nombre)) 
//{
//    Console.WriteLine("string vacio");
//}
//else
//{
//    Console.WriteLine(nombre);
//}

//int numero = 9;
//string numeroConCero = "99";
//numeroConCero = numeroConCero.PadLeft(3, '$');
//Console.WriteLine(numeroConCero);

string nombre = "Sergio";
string apellido = "Cazares";
int edad = 18;

//string nombreYedad = nombre + "|" + apellido + "|" + edad;
//Console.WriteLine(nombreYedad);

//string nombreYedad = string.Format("{0}|{1}|{2}", nombre, apellido, edad);
//Console.WriteLine(nombreYedad);

string nombreYedad = $"{nombre}|{apellido}|{edad}";
Console.WriteLine(nombreYedad);

