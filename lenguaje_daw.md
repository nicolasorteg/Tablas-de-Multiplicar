### Guía del Lenguaje DAW

Esta guía proporciona una visión general de los conceptos básicos del lenguaje DAW, diseñado para ser sencillo y fácil de aprender.
Con ella podrás entender la sintaxis y las estructuras fundamentales necesarias para comenzar a programar. Es importante seguir las convenciones y buenas prácticas recomendadas para escribir código claro y mantenible.

- [Guía del Lenguaje DAW](#guía-del-lenguaje-daw)
  - [0. Comentarios](#0-comentarios)
  - [1. Estructura del Programa](#1-estructura-del-programa)
  - [2. Tipos de Datos](#2-tipos-de-datos)
  - [3. Variables y Constantes](#3-variables-y-constantes)
  - [4. Conversión de Tipos (Casting)](#4-conversión-de-tipos-casting)
  - [5. Enumeraciones](#5-enumeraciones)
  - [6. Operadores](#6-operadores)
  - [7. Precedencia de Operadores](#7-precedencia-de-operadores)
  - [8. Entrada y Salida](#8-entrada-y-salida)
- [8. Programación Estructurada](#8-programación-estructurada)
  - [8.1. Secuencias](#81-secuencias)
  - [8.2. Condicionales](#82-condicionales)
  - [8.3. Bucles](#83-bucles)
- [9. Programación Modular](#9-programación-modular)
  - [9.1. Funciones y Procedimientos](#91-funciones-y-procedimientos)
  - [9.2. Parámetros y Argumentos](#92-parámetros-y-argumentos)
  - [9.3. Paso por Valor vs. Paso por Referencia](#93-paso-por-valor-vs-paso-por-referencia)
  - [9.4. Ámbito de las Variables](#94-ámbito-de-las-variables)
  - [9.5. Parámetros por Defecto, Opcionales y Nombrados](#95-parámetros-por-defecto-opcionales-y-nombrados)
  - [9.6. Sobrecarga de Funciones y Procedimientos](#96-sobrecarga-de-funciones-y-procedimientos)
  - [9.7. Parámetros Variables (`params`)](#97-parámetros-variables-params)
  - [9.8. Parámetros de Salida (`out`)](#98-parámetros-de-salida-out)
  - [9.9. Recursividad](#99-recursividad)
  - [9.10. Paquetes o Módulos](#910-paquetes-o-módulos)
- [Guía del Lenguaje DAW](#guía-del-lenguaje-daw-1)
- [10. Control de Excepciones](#10-control-de-excepciones)
  - [10.1. Bloques `try-catch` y `finally`](#101-bloques-try-catch-y-finally)
  - [10.2. Lanzar Excepciones (`throw`) y Aserciones (`assert`)](#102-lanzar-excepciones-throw-y-aserciones-assert)


-----

#### 0\. Comentarios

Notas que el programa ignora y sirven para explicar el código.

  * **Comentario de una línea:** Empieza con `//`.
    ```csharp
    // Esto es un comentario de una sola línea.
    int edad = 30; // También al final de una línea.
    ```
  * **Comentario de varias líneas:** Empieza con `/*` y finaliza con `*/`.
    ```csharp
    /*
    Este es un comentario
    que ocupa varias líneas.
    */
    ```

-----

#### 1\. Estructura del Programa

Todo el código se escribe dentro de un bloque principal `Main`, que es el punto de entrada que se ejecuta al iniciar el programa. Cada instrucción termina con punto y coma (`;`). El código es sensible a mayúsculas y minúsculas y los bloques de código se delimitan con llaves `{}`.
Además, se recomienda usar indentación (tabulaciones o espacios) para mejorar la legibilidad.

```csharp
Main {
    // Aquí va el código de nuestro programa.
    writeLine("¡Hola, mundo!");
}
```

-----

#### 2\. Tipos de Datos

Definen qué valores puede almacenar una variable. Los principales son:

  * **`int`**: Almacena números enteros. Su valor por defecto es `0`.
  * **`decimal`**: Almacena números con decimales de alta precisión. Su valor por defecto es `0.0`.
  * **`string`**: Almacena texto. Su valor por defecto es `""` (cadena vacía).
  * **`bool`**: Almacena `true` o `false`. Su valor por defecto es `false`.

-----

#### 3\. Variables y Constantes

Usaremos la convención **`camelCase`** para variables y `readonly`, y **`MAYUSCULAS_CON_GUIONES`** para constantes.

  * **Variables:** Contenedores cuyo valor puede cambiar. Es una buena práctica inicializarlas siempre. Son almacenadas en memoria y tienen un tipo fijo, deben declararse antes de usarse y su tipo no puede cambiar. Son de Lectura y Escritura, es decir, se pueden leer y modificar.
    ```csharp
    Main {
      int edad = 20;
      string nombre = "Ana";
    }
    ```
    * Declaración: `tipo nombre = valor_inicial;` Ejemplo: `int contador = 0;`
    * Asignación: `nombre = "Pedro";` (cambia el valor de la variable)
    * Inicialización: Asignar un valor al declararla.
   
     ```csharp
     Main {
      int contador;        // Declaración sin inicializar (no recomendado)
      contador = 0;       // Asignación posterior
      int total = 100;    // Declaración e inicialización en una línea (recomendado)
    }
    ```

  * **Inferencia de Tipos con `var`:** El compilador deduce el tipo a partir del valor. La variable debe ser inicializada y su tipo no puede cambiar después.
    ```csharp
    Main {
      var edad = 25;        // Se infiere que es int
      var nombre = "Juan";  // Se infiere que es string
      // var x;      // ERROR: no se puede inferir sin un valor
      // edad = "Pedro";  // ERROR: una vez es int, no puede ser string
    }
    ```
  * **Variables Nulas (`?`):** Para permitir que una variable almacene `null` (ausencia de valor), se añade `?`. `null` es diferente de un valor por defecto como `0` o `""`. Debes tener cuidado al usar variables que pueden ser `null` para evitar errores en tiempo de ejecución.
    ```csharp
    Main {
      string apellido = "";        // Caja con una cadena vacía
      string? segundoApellido = null; // La caja está vacía, no hay valor
      int? edadOpcional = null;
    }
    ```
  * **Constantes (`const`):** Valores fijos que no pueden cambiar y deben inicializarse al declararse. Son útiles para valores que no deben modificarse.
    ```csharp
    Main {
      const decimal PI = 3.1416m;
      const int MAX_ALUMNOS = 30;
    }
    ```
  * **Variables de solo lectura (`readonly`):** Su valor se asigna una sola vez (al declarar o después) y luego no puede cambiar. 
    ```csharp
    Main {
      readonly string version = "1.0";
      readonly int anoNacimiento;
      anoNacimiento = 1990; // Se asigna una vez
      // anoNacimiento = 1991; // ERROR: ya fue asignado
    }
    ```
-----

#### 4\. Conversión de Tipos (Casting)

Es el proceso de cambiar un valor de un tipo a otro.

  * **Conversión Implícita:** El lenguaje la realiza automáticamente si no hay riesgo de perder datos.
    ```csharp
    Main {
      int numeroInt = 10;
      decimal numeroDecimal = numeroInt; // Conversión implícita de int a decimal
    }
    ```
  * **Conversión Explícita:** Se indica manualmente con `(tipo)` cuando puede haber pérdida de información.
    ```csharp
    Main {
      decimal numeroDecimal = 9.8m;
      int numeroInt = (int)numeroDecimal; // Se trunca la parte decimal, el resultado es 9
    }

-----

#### 5\. Enumeraciones

Permite crear un tipo de dato con un conjunto de constantes con nombre, haciendo el código más legible.

```csharp
Main {
  // Definición de la enumeración
  enum DiasSemana { LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO }

  // Uso de la enumeración
  var hoy = DiasSemana.Miercoles;
  writeLine("Hoy es " + hoy); // Muestra "Hoy es MIERCOLES"

  var mañana = DiasSemana.Jueves;
  writeLine("Mañana es " + mañana); // Muestra "Mañana es JUEVES"
}
```


-----

#### 6\. Operadores

  * **Operadores Aritméticos:** `+`, `-`, `*`, `/`, `%` (módulo o resto).
    *La división `/` se comporta diferente según el tipo:*
    ```csharp
    Main {
      int resultadoEntero = 9 / 2;      // Resultado: 4 (división entera)
      decimal resultadoDecimal = 9.0 / 2.0; // Resultado: 4.5 (división decimal)
    }
    ```
  * **Operadores de Asignación:** `=`, `+=`, `-=`, `*=`, `/=`.
    ```csharp
    Main {
      int x = 5;      // Asignación
      x += 3;         // Equivale a x = x + 3; Ahora x es 8
      x *= 2;         // Equivale a x = x * 2; Ahora x es 16
    }
    ```
  * **Operadores de Comparación:** `==`, `!=`, `>`, `<`, `>=`, `<=`. Devuelven `bool`.
    ```csharp
    Main {
      int a = 5;
      int b = 10;
      bool esIgual = (a == b);      // false
      bool esDiferente = (a != b);  // true
      bool esMayor = (a > b);       // false
      bool esMenorIgual = (a <= b); // true
    }
    ```
  * **Operadores Lógicos:** `&&` (Y), `||` (O), `!` (NO).
    ```csharp
    Main {
      bool esMayor = true;
      bool tienePermiso = false;
      bool puedeEntrar = esMayor && tienePermiso; // Resultado: false
      bool puedeSalir = esMayor || tienePermiso; // Resultado: true
      bool noEsMayor = !esMayor; // Resultado: false
    }
    ```
  * **Concatenación de Cadenas:** El operador `+` une cadenas de texto.
    ```csharp
    Main {
      int edad = 20;
      // Para operaciones matemáticas, usar paréntesis:
      writeLine("Dentro de 5 años tendrás " + (edad + 5)); // Muestra "Dentro de 5 años tendrás 25"
    }
    ```
  * **Operador Ternario (`? :`):** Selecciona entre dos valores según una condición.
    ```csharp
    Main {
      int edad = 20;
      string mensaje = (edad >= 18) ? "Eres mayor de edad" : "Eres menor de edad";
      writeLine(mensaje); // Muestra "Eres mayor de edad"
    }
    ```
  * **Operador de Nulidad (`??`):** Proporciona un valor por defecto si una variable es `null`.
    ```csharp
    Main {
      string? nombre = null;
      string nombreFinal = nombre ?? "Desconocido";
      writeLine(nombreFinal); // Muestra "Desconocido"
    }
    ```

-----

#### 7\. Precedencia de Operadores

Indica el orden en que se ejecutan las operaciones. Se puede alterar usando paréntesis `()`.

1.  `()`
2.  `*`, `/`, `%`
3.  `+`, `-`
4.  Operadores de comparación (`>`, `==`, etc.)
5.  `!` (NOT)
6.  `&&` (AND)
7.  `||` (OR)


```csharp
Main {
  // Sin paréntesis, la multiplicación va primero
  int resultado1 = 5 + 2 * 3; // 5 + 6 = 11
  // Con paréntesis, la suma va primero
  int resultado2 = (5 + 2) * 3; // 7 * 3 = 21
  writeLine("Resultado1: " + resultado1); // Muestra 11
  writeLine("Resultado2: " + resultado2); // Muestra 21
}
```

-----

#### 8\. Entrada y Salida

  * **Salida (`writeLine`):** Muestra texto o valores en la consola.
    ```csharp
    Main 
      string nombre = "Ana";
      writeLine("Hola, " + nombre);
    }
    ```
  * **Entrada (`readLine`):** Lee texto introducido por el usuario. **Siempre devuelve un `string`**, por lo que necesita casting explícito para convertirlo a otros tipos.
    ```csharp
    Main {
      // Leer un string
      writeLine("Introduce tu nombre:");
      string nombreUsuario = readLine();

      // Leer un entero (int)
      writeLine("Introduce tu edad:");
      int edadUsuario = (int)readLine();

      // Leer un decimal
      writeLine("Introduce el precio:");
      decimal precioProducto = (decimal)readLine();

      // Leer un booleano (bool)
      writeLine("¿Estás de acuerdo? (true/false):");
      bool acuerdo = (bool)readLine();
    }
    ```

-----


### 8\. Programación Estructurada

La **programación estructurada** es un paradigma que busca crear programas más claros y fáciles de mantener. Se basa en el **Teorema de la programación estructurada**, que demuestra que cualquier algoritmo puede ser implementado utilizando únicamente tres estructuras de control básicas: **secuencia**, **condicional** y **bucle**.

#### 8.1. Secuencias

Es la estructura más simple, donde las instrucciones se ejecutan una tras otra, en el orden en que están escritas.

```csharp
Main {
    // Ejemplo de Secuencia
    writeLine("Hola");
    writeLine("¿Cómo estás?");

    // Leemos el nombre del usuario
    writeLine("Por favor, introduce tu nombre:");
    string nombre = readLine();

    // Mostramos un saludo personalizado
    writeLine("Encantado de conocerte, " + nombre);
}
```

#### 8.2. Condicionales

Permiten que el programa tome decisiones y se comporte de manera diferente según las circunstancias.

  * **Condicional simple (`if`)**: Evalúa una condición booleana y ejecuta un bloque de código si es verdadera.
  * **Condicional compuesto (`if-else`)**: Permite ejecutar un bloque de código si se cumple una condición y otro si no.
  * **Condicionales múltiples (`if-else if-else`)**: Permiten encadenar varias condiciones. El programa evalúa las condiciones en orden y ejecuta el bloque de la primera que sea verdadera.
  * **Estructura `switch`**: Ofrece una alternativa más limpia a una larga cadena de `if-else if` para comparar una única variable con múltiples valores posibles.

<!-- end list -->

```csharp
Main {
    // Condicionales múltiples
    var edadAlumno = 16;
    if (edadAlumno >= 18) {
        writeLine("Eres mayor de edad.");
    } else if (edadAlumno >= 16) {
        writeLine("Casi eres mayor de edad.");
    } else {
        writeLine("Eres menor de edad.");
    }

    // Ejemplo de switch
    var dia = 3;
    string nombreDelDia;

    switch (dia) {
        case 1:
            nombreDelDia = "Lunes";
            break;
        case 2:
            nombreDelDia = "Martes";
            break;
        case 3:
            nombreDelDia = "Miércoles";
            break;
        case 6:
        case 7:
            nombreDelDia = "Fin de semana";
            break;
        default:
            nombreDelDia = "Día inválido";
            break;
    }
    writeLine("Hoy es: " + nombreDelDia);
}
```

#### 8.3. Bucles

Los bucles permiten repetir un bloque de código varias veces.

  * **Bucles indefinidos (`while` y `do-while`)**: Se ejecutan mientras se cumpla una condición y son útiles cuando no se sabe cuántas iteraciones se necesitarán. El `do-while` garantiza que se ejecute al menos una vez.
  * **Bucles definidos (`for`)**: Se utilizan cuando se sabe de antemano cuántas veces se quiere repetir un bloque de código. Se componen de tres partes: inicialización, condición y actualización. `for each` es una variante que recorre cada elemento de una colección.
  * **Recorriendo arrays con `for` y `for each`**: Una aplicación común de los bucles es recorrer colecciones de datos, como arrays.

<!-- end list -->

```csharp
Main {
    // Ejemplo de bucle while
    var contador = 0;
    while (contador < 5) {
        writeLine("Contador: " + contador);
        contador = contador + 1;
    }

    // Ejemplo de bucle do-while
    var numero = 0;
    do {
        writeLine("Número: " + numero);
        numero = numero + 1;
    } while (numero < 3);

    // Ejemplo de bucle for
    for (int i = 0; i <= 5; i = i + 1) {
        writeLine("Contador for: " + i);
    }
}
```

-----

### 9\. Programación Modular

La **programación modular** es un paradigma que divide un programa grande en partes más pequeñas e independientes, llamadas **módulos**. Las ventajas son que facilita la resolución del problema, aumenta la claridad y permite que varios programadores trabajen en el mismo proyecto. La descomposición modular se basa en la técnica "Divide y Vencerás" (DAC o Divide And Conquer).

#### 9.1. Funciones y Procedimientos

  * **Función**: Un bloque de código que realiza una tarea específica y **devuelve un valor** mediante la sentencia `return`.
  * **Procedimiento**: Similar a una función, pero **no devuelve ningún valor**.

<!-- end list -->

```csharp
// Función
function int sumar(int a, int b) {
    return a + b;
}

// Procedimiento
procedure saludar(string nombre) {
    writeLine("Hola, " + nombre + "!");
}

Main {
    int resultado = sumar(5, 3);
    writeLine("La suma es: " + resultado);
    saludar("Ana");
}
```

#### 9.2. Parámetros y Argumentos

Los **parámetros** son las variables definidas en la declaración de una función o procedimiento. Los **argumentos** son los valores reales que se pasan al llamar a la función.

#### 9.3. Paso por Valor vs. Paso por Referencia

  * **Paso por valor**: La función recibe una **copia** del dato original. Los cambios dentro de la función no afectan a la variable original fuera de ella. Es el comportamiento por defecto en DAW.
  * **Paso por referencia (`ref`)**: La función recibe la **dirección de memoria** de la variable original. Cualquier cambio que hagas al parámetro dentro de la función modificará directamente la variable original.

<!-- end list -->

```csharp
// Ejemplo de paso por referencia
procedure duplicar(ref int numero) {
    numero = numero * 2;
}

Main {
    var valorOriginal = 10;
    writeLine("Antes de la llamada: " + valorOriginal); // Imprime 10
    duplicar(ref valorOriginal);
    writeLine("Después de la llamada: " + valorOriginal); // Imprime 20
}
```

#### 9.4. Ámbito de las Variables

El **ámbito** de una variable determina dónde puede ser accedida o modificada.

  * **Ámbito global**: Las variables declaradas fuera de cualquier función y son accesibles desde cualquier parte del programa. **Su uso excesivo no es recomendable**.
  * **Ámbito local**: Las variables declaradas dentro de una función o procedimiento, y solo pueden ser accedidas y modificadas dentro de ese bloque.

<!-- end list -->

```csharp
var contadorGlobal = 0;
procedure incrementarContador() {
    var contadorLocal = 0;
    contadorLocal = contadorLocal + 1;
    contadorGlobal = contadorGlobal + 1;
    writeLine("Contador Local: " + contadorLocal);
    writeLine("Contador Global: " + contadorGlobal);
}

Main {
    incrementarContador();
    incrementarContador();
}
```

#### 9.5. Parámetros por Defecto, Opcionales y Nombrados

  * **Parámetros por defecto**: Permiten definir un valor predeterminado para un parámetro.
  * **Parámetros opcionales**: Son parámetros con valores por defecto que se pueden omitir al llamar a la función.
  * **Parámetros nombrados**: Permiten especificar los nombres de los parámetros al llamar a una función, permitiendo pasar argumentos en un orden diferente.

<!-- end list -->

```csharp
procedure mostrarInfo(string nombre, int edad = 18) {
    writeLine("Nombre: " + nombre);
    writeLine("Edad: " + edad);
}

Main {
    mostrarInfo("Ana", 25);
    mostrarInfo("Marta");
}
```

#### 9.6. Sobrecarga de Funciones y Procedimientos

La **sobrecarga** permite definir múltiples funciones o procedimientos con el mismo nombre, pero con diferentes listas de parámetros (diferente número o tipos de parámetros).

```csharp
function int calcularArea(int lado) {
    return lado * lado;
}

function decimal calcularArea(decimal radio) {
    return 3.1416m * radio * radio;
}

Main {
    int areaCuadrado = calcularArea(5);
    decimal areaCirculo = calcularArea(3.5m);
}
```

#### 9.7. Parámetros Variables (`params`)

Permiten que una función acepte un número indeterminado de valores del mismo tipo. Se define usando la palabra clave `params` antes del tipo del parámetro y debe ser el último en la lista de parámetros.

```csharp
function int sumarTodos(params int numeros) {
    int suma = 0;
    for each (var num in numeros) {
        suma = suma + num;
    }
    return suma;
}

Main {
    int total = sumarTodos(1, 2, 3, 4, 5);
}
```

#### 9.8. Parámetros de Salida (`out`)

Permiten que una función o procedimiento devuelva múltiples valores. No es necesario inicializar las variables que se pasan como parámetros de salida.

```csharp
procedure obtenerDatos(out string nombre, out int edad) {
    nombre = "Ana";
    edad = 25;
}

Main {
    string nombre;
    int edad;
    obtenerDatos(out nombre, out edad);
    writeLine("Nombre: " + nombre + ", Edad: " + edad);
}
```

#### 9.9. Recursividad

Es una técnica que consiste en llamar a una función o procedimiento dentro de sí mismo. Es importante incluir una **condición de parada** para evitar un bucle infinito.

```csharp
function int factorial(int n) {
    if (n <= 1) {
        return 1;
    } else {
        return n * factorial(n - 1);
    }
}
```

#### 9.10. Paquetes o Módulos

Un **paquete** o **módulo** (también conocido como librería) es un archivo o conjunto de archivos que agrupa funciones, procedimientos y tipos de datos relacionados. Para usarlas, se deben importar con la palabra clave `using`.

```csharp
using Math;

Main {
    decimal raiz = Math.sqrt(16.0m);
    int numeroAleatorio = Math.random(1, 10);
}
```
Para actualizar la guía del lenguaje DAW, he añadido una nueva sección sobre el control de excepciones, resumiendo los conceptos clave que hemos definido.

-----

### Guía del Lenguaje DAW

-----

### 10\. Control de Excepciones

El **control de excepciones** es una técnica para gestionar errores inesperados que ocurren durante la ejecución de un programa. En DAW, las excepciones son **no requeridas** (unchecked), lo que significa que el compilador no te obliga a manejarlas, ofreciendo un código más limpio a cambio de una mayor responsabilidad del desarrollador para prevenirlos. La clase base de todas las excepciones es **`Exception`**.

#### 10.1. Bloques `try-catch` y `finally`

  * **`try`**: Encierra el código que podría generar un error.
  * **`catch`**: Captura y maneja una excepción si ocurre en el bloque `try`.
  * **`finally`**: Contiene código que se ejecuta siempre, independientemente de si hubo una excepción o no.

<!-- end list -->

```csharp
Main {
    try {
        int resultado = 10 / 0; // Esto generará una excepción
    } catch (Exception e) {
        writeLine("Error: " + e.message); // Captura el error
    } finally {
        writeLine("El proceso ha terminado.");
    }
}
```

#### 10.2. Lanzar Excepciones (`throw`) y Aserciones (`assert`)

  * **`throw`**: Se usa para lanzar una excepción de forma manual, interrumpiendo el flujo del programa. Es útil para validar errores de lógica de negocio.
  * **`assert`**: Es una herramienta de depuración que verifica una condición. Si es falsa, lanza una `AssertionException`. Se utiliza para validar supuestos durante el desarrollo, no para datos de usuario. No es recomendable dejar aserciones en el código de producción, ya que están destinadas a detectar errores lógicos durante la fase de desarrollo y prueba.

<!-- end list -->

```csharp
function decimal dividir(int numerador, int divisor) {
    // Lanzar una excepción de forma manual si el divisor es cero
    if (divisor == 0) {
        throw new DivideByZeroException("No se puede dividir por cero.");
    }
    return (decimal)numerador / divisor;
}

function validarEdad(int edad) {
    // Usar una aserción para la depuración
    assert(edad > 0, "La edad debe ser un número positivo.");
}
```