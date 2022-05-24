// Crea un programa que pida al usuario un número entero y diga si este es par o impar. 

/*
    1. Pedir al usuario un número
    2. Leer el número que me da el usuario
    3. Comprobar si el número es válido
        3.a Si el número es válido 
            3.a.1 Compruebo si es par (4)
        3.b Si el número no es válido 
            3.b.1 Mostar mensaje de error y
        3.1 Preguntar al usuario qué quiere hacer (90)
            3.1.a Volver a pedir número (1)
            3.1.b Cerrar programa (99)
    4. Compruebo si es par
        4.1 Calcular el módulo [%] del número dividido entre 2 y guardarlo en variable "resultado"
        4.2 Comprobamos si la variable "resultado" es igual a cero 
            4.2.a SI es igual a cero
                4.2.a.1 Imprimir mensaje "El número dado es PAR"
                4.2.a.2 Preguntar al usuario qué quiere hacer (90)
                    4.2.a.2.a Volver a pedir número (1)
                    4.2.a.2.b Cerrar programa (99)
            4.2.b NO es igual a cero
                4.2.b.1 Imprimir mensaje "El número dado es IMPAR"
                4.2.b.2 Preguntar al usuario qué quiere hacer (90)
                    4.2.b.2.a Volver a pedir número (1)
                    4.2.b.2.b Cerrar programa (99)
    90. Preguntar al usuario qué quiere hacer
        90.a Volver a pedir número (1)
        90.b Cerrar programa (99)
    99. Cerrar programa
*/

/* esto es un comentario para probar el sistema de actualizaciones de repos */
// Y esto es otro comentario más
// y este es el tercero

public int numeroPedidoAlUsuario;

void Start(){
    int resultado;

    do{
        numeroPedidoAlUsuario = pideNumeroUsuario();

        string mensaje = dimeSiEsPar(numeroPedidoAlUsuario);
        Console.WriteLine(mensaje);

        bool respuesta = queHacemosAhora();
    } while( respuesta == true );  // quiere continuar   
    Console.WriteLine("Hasta la próxima!"); 
}


int pideNumeroUsuario(){
    // declarar variable para guardar número
    int num;
    // Mostrar mensaje de solicitud
    Console.WriteLine("Dime un número entero: ");
    // Leer número y guardamos en variable
    num = int.Parse(Console.ReadLine());  // Parse ya nos comprueba si el número es válido
    // Devolver Variable
    return num;
}

string dimeSiEsPar(int numero){
    int resultado;
    //4.1 Calcular el módulo [%] del número dividido entre 2 y guardarlo en variable "resultado"
    resultado = numero % 2;

    // 4.2 Comprobamos si la variable "resultado" es igual a cero 
    if( resultado == 0 ){
        //Console.WriteLine("El número es PAR");
        return "El número es PAR";
    }
    // 4.2.b NO es igual a cero
    else if( resultado != 0 ){
        return "El número es IMPAR";
    } 
}

bool queHacemosAhora(){
    // true si seguimos 
    // false si terminamos
    bool respuestaBooleana;
    string respuestaTexto;
    do{        
        //Preguntamos
        Console.WriteLine("Quieres probar con otro número? (S/N) ");
        // Leemos
        respuestaTexto = Console.ReadLine();
        // Comprobamos
        if( respuestaTexto.Equals("S") ){
            respuestaBooleana = true;
        }
        else if ( respuestaTexto.Equals("N") ){
            respuestaBooleana = false;
        }
        else{
            Console.WriteLine("Opción incorrecta");
        }
    } while( !respuestaTexto.Equals("S") && !respuestaTexto.Equals("N"));
    
    // Devolvemos resultado
    return respuestaBooleana;

}
