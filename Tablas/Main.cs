Main {

    writeLine("-- Bienvenido a las Tablas de Multiplicar.");

    ejecutarSimulacion()

    writeLine("Ha sido un placer 🤗, aquí tienes las tablas del 0-10 por si las quieres revisar.");
    mostrar10PrimerasTablas();
}

procedure ejecutarSimulacion() {

    int numero;
    string opcionElegida;

    do {
        numero = leerNumero("¿De qué número desea las tablas?: ");

        mostrarTabla(numero);

        writeLine("¿Desea imprimir otra tabla? (s/n): ");
        opcionElegida = readLine();

    } while((opcionElegida == "s") || (opcionElegida == "S"));
}


function int leerNumero(string message) {
    int numero;
    bool isValido = false;

    do {
        writeLine(message);
        try {
            numero = (int)readLine();
            isValido = true;
        } catch (FormatoException e) {
            writeLine("❌ Introduce un número entero.");
        }
    } while(!isValido);

    return numero;
}

procedure mostrarTabla (int numero) {

    for (int i = 0; i <= numero; i += 1) {
        writeLine(numero + " * " + i + " = " + (numero * i));
    }
    writeLine("Fin de la tabla.");
}

procedure mostrar10PrimerasTablas () {

    int numero = 0;

    do {
        for (int i = 0; i <= 10; i += 1) {
            writeLine(numero + " * " + i + " = " + (numero * i));
        }
        writeLine("Fin de la tabla.");

        numero += 1;

    } while (numero <= 10);
}