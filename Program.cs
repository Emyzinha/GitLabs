var operação = args[0];
var n1 =Convert.ToDouble( args [1]);
var n2 =Convert.ToDouble( args [2]);



if (operação == "Somar")
{
    Console.WriteLine(n1 + n2);
}

if (operação == "Subtrair")
{
    Console.WriteLine(n1-n2);
}

if (operação == "Multiplicar")
{    
    Console.WriteLine(n1*n2);
}

if (operação == "Dividir")
{    
    Console.WriteLine(n1/n2);
}