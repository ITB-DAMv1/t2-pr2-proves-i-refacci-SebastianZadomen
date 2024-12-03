# Clases de Equivalencia, Valores Límite y Casos de Prueba

## 1. **Método `ClassifyAge(int age)`**

Este método clasifica las edades según el valor dado en la libraria (archivo dll):
- Entrada válida: edades entre 0 y 120 (inclusive).
- Entrada no válida: edades menores a 0 o mayores a 120.

### Clases de Equivalencia:
- Edad válida: 0 ≤ age ≤ 120  
  Ejemplos: 0, 18, 65, 120
- Edad no válida: age < 0 o age > 120  
  Ejemplos: -1, 121

### Valores Límite:
- Límite minimo: age = 0
- Límite maximo: age = 120
- Fuera del límite minimo: age = -1
- Fuera del límite maximo: age = 121

### Casos de Prueba:
1. Edad válida, infància (0 - 17 años): ClassifyAge(0) → 0
2. Edad válida, adulta (18 - 65 años): ClassifyAge(18) → 1
3. Edad válida, senescència (mayores de 65 años): ClassifyAge(66) → 2
4. Edad fuera del rango minimo: ClassifyAge(-1) → -1
5. Edad fuera del rango maximo: ClassifyAge(121) → -1

---

## 2. **Método `IsEven(int age)`**

Este método determina si la edad es par o impar.

### Clases de Equivalencia:
- Edad par: age % 2 == 0
  Ejemplos: 0, 2, 4, 18
- Edad impar: age % 2 != 0 
  Ejemplos: 1, 3, 5, 17


### Casos de Prueba:
1. Edad par: IsEven(2) → true
2. Edad impar: IsEven(3) → false
3. Edad par (límite menor): IsEven(0) → true
4. Edad impar (límite superior): IsEven(1) → false

---

## 3. **Método `NameAnalyser(string name)`**

Este método analiza si un nombre es corto (menos de 5 caracteres) y si es un palíndromo.

### Clases de Equivalencia:
- Nombre corto: length(name) < 5`
  Ejemplos: "Sylys", "Ana"
- Nombre largo: length(name) <= 5  
  Ejemplos: "Rocío", "María"
- Nombre palíndromo: el nombre es igual al revés.  
  Ejemplos: "otto", "Ana"
- Nombre no palíndromo: el nombre no es igual al revés.  
  Ejemplos: "Lucia", "Marta"

### Valores Límite:
- Longitud mínima de nombre corto: 1 carácter
- Longitud máxima de nombre corto: 4 caracteres
- Longitud mínima de nombre largo: 5 caracteres

### Casos de Prueba:
1. Nombre corto y palíndromo: NameAnalyser("Ana") → (true, true)
2. Nombre corto y no palíndromo: NameAnalyser("Ren") → (true, true)
3. Nombre largo y palíndromo: NameAnalyser("Otto") → (false, true)
4. Nombre largo y no palíndromo: NameAnalyser("Lucia") → (false, false)

---

## 4. **Método `VerifyColour(string colour)`**

Este método verifica el tipo de color según su clasificación.

### Clases de Equivalencia:
- Colores calmantes: "blau", "verd"  
  Ejemplos: "blau", "verd"
- Colores exclusivos: "vermell", "groc"  
  Ejemplos: "vermell", "groc"
- Colores no válidos: cualquier otro color 
  Ejemplos: "rojo", "blanco", "azul"

### Valores Límite:
- Color válido, calmante: "blau", "verd"
- Color válido, exclusivo: "vermell", "groc"
- Color inválido: cualquier otro

### Casos de Prueba:
1. Color calmante (blau): VerifyColour("blau") → 0
2. Color calmante (verd): VerifyColour("verd") → 0
3. Color exclusivo (vermell)**: VerifyColour("vermell")→ 1
4. Color exclusivo (groc)**: VerifyColour("groc") → 1
5. Color inválido: VerifyColour("rojo") → -1

---

## 5. **Método `PersonalityTest(string preference)`**

Este método determina el tipo de personalidad según la preferencia de tiempo.

### Clases de Equivalencia:
- Preferencia matinal: "matí"  
  Ejemplos: "matí"
- Preferencia nocturna: "nit"  
  Ejemplos: "nit"
- Preferencia imprevista: cualquier otro valor  
  Ejemplos: "tarda", "diumenge"

### Valores Límite:
- Preferencia válida, matinal: "matí"
- Preferencia válida, nocturna: "nit"
- Cualquier otra preferencia: cualquier valor distinto de "matí" y "nit"

### Casos de Prueba:
1. Preferencia matinal: PersonalityTest("matí") → 0
2. Preferencia nocturna: PersonalityTest("nit") → 1
3. Preferencia imprevista: PersonalityTest("tarda") → 2
4. Preferencia imprevista (valor inválido): PersonalityTest("") → 2

---

# Resumen de las categorías

| **Función**                  | **Clases de Equivalencia**   | **Valores Límite**       | **Casos de Prueba**                    |
|------------------------------|------------------------------|--------------------------|----------------------------------------|
| `ClassifyAge(int age)`        | Edad válida [0-120]           | 0, 120, -1, 121           | Casos con valores dentro y fuera del rango |
| `IsEven(int age)`             | Edad par, edad impar          | 0, 1                     | Casos con valores pares e impares |
| `NameAnalyser(string name)`   | Nombre corto, nombre largo    | 4, 5                     | Casos con nombres palíndromos, largos, cortos |
| `VerifyColour(string colour)` | Calmante, exclusivo, inválido | "blau", "vermell", "rojo" | Casos con colores válidos e inválidos |
| `PersonalityTest(string preference)` | Matinal, nocturna, imprevista | "matí", "nit"              | Casos con preferencias válidas e inválidas |