## 📝 Ejercicio 4: Teoría sobre el tipo String

### 1. ¿`string` es un tipo por valor o un tipo por referencia?
En C#, `string` es un **tipo por referencia**, es decir que la variable no guarda el texto directamente, sino que guarda la dirección de memoria donde está almacenado ese texto.

> **Dato importante:** Aunque es un tipo por referencia, C# está diseñado para que se comporte en muchos aspectos como un tipo por valor. Por ejemplo, al usar el operador `==` se compara el contenido del texto y no la dirección de memoria. Además, los strings son **inmutables** (no se pueden modificar una vez creados; si se intenta cambiar uno, el programa crea uno nuevo en la memoria por detrás).

---

### 2. ¿Qué secuencias de escape tiene el tipo `string`?

* `\n` : Nueva línea (salto de línea).
* `\t` : Tabulación horizontal (agrega un espacio largo).
* `\\` : Imprime una barra invertida literal.
* `\"` : Imprime una comilla doble (ideal para citar texto adentro de un string).
* `\'` : Imprime una comilla simple.
* `\r` : Retorno de carro.

---

### 3. ¿Qué sucede cuando se utiliza el carácter `@` y `$` antes de una cadena de texto?

* **El carácter `@`:** Le indica al compilador que **ignore por completo las secuencias de escape**. Toma el texto literalmente, tal cual se escribe. 

  // Sin @ 
  string ruta1 = "C:\\Facultad\\TP6\\archivo.txt"; 
  
  // Con @ 
  string ruta2 = @"C:\Facultad\TP6\archivo.txt";