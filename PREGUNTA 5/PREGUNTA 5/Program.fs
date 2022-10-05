// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let suma x y = x+y
let resta x y =x-y
let multi x y =x*y
let divi x y= x/y

[<EntryPoint>]
let main argv = 
    Console.WriteLine("Introduzca 2 numeros"); 
    let x=Console.ReadLine();
    let y=Console.ReadLine();
    let valorX=Convert.ToInt32(x) 
    let valorY=Convert.ToInt32(y)
    //FUNCION SUMA
    Console.WriteLine("LA SUMA ES: ");
    Console.WriteLine(suma valorX valorY)

    //FUNCION RESTA
    Console.WriteLine("LA RESTA ES: ");
    Console.WriteLine(resta valorX valorY)

    //FUNCION MULTI
    Console.WriteLine("LA MULTIPLICACION ES: ");
    Console.WriteLine(multi valorX valorY)

    //FUNCION DIVI
    Console.WriteLine("LA DIVISION ES: ");
    Console.WriteLine(divi valorX valorY)


    let tecla=Console.ReadKey()
    0 // devolver un código de salida entero
