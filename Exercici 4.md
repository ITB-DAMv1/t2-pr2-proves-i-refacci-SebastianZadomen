
# Clases de Equivalencia

### 1. **Para el cálculo del área del rectángulo**:
- **Clase válida (positiva)**:
    - **Ancho > 0 y Alto > 0** → Área positiva válida.
- **Clase inválida**:
    - **Ancho ≤ 0 o Alto ≤ 0** → El área es inválida o 0 (entrada incorrecta).

- **Clase de equivalencia para el área**:
    - **Área > 50** → El mensaje será "El área es mayor a 50".
    - **20 < Área ≤ 50** → El mensaje será "El área está entre 20 y 50".
    - **Área ≤ 20** → El mensaje será "El área es menor o igual a 20".

### 2. **Para el cálculo de la circunferencia del círculo**:
- **Clase válida (positiva)**:
    - **Radio > 0** → Circunferencia válida.
- **Clase inválida**:
    - **Radio ≤ 0** → Circunferencia inválida o 0 (entrada incorrecta).

---

# Valores Límite

### 1. **Para el cálculo del área del rectángulo**:
- **Límites para el área**:
    - **Área = 0**: Si el ancho o el alto es igual a 0.
    - **Área = 50**: Si el producto de ancho y alto es 50 (e.g., Ancho = 5, Alto = 10).
    - **Área > 50**: Si el producto es mayor que 50 (e.g., Ancho = 6, Alto = 10).

### 2. **Para el cálculo de la circunferencia del círculo**:
- **Límites para el radio**:
    - **Radio = 0**: La circunferencia será 0.
    - **Radio = 1**: Circunferencia mínima positiva.
    - **Radio = 7**: Un valor estándar para la prueba.
    - **Radio = 50**: Un valor mayor para la circunferencia.

---

#  Casos de Prueba

### 1. **Pruebas para el cálculo del área del rectángulo:**

| Caso de prueba                            | Descripción                                                                 | Entrada (Ancho, Alto) | Salida Esperada                                |
|-------------------------------------------|-----------------------------------------------------------------------------|-----------------------|------------------------------------------------|
| **Prueba 1: Área mayor a 50**             | Verificar si el área es mayor a 50.                                          | 10, 6                 | Área = 60, Mensaje = "El área es mayor a 50"   |
| **Prueba 2: Área entre 20 y 50**          | Verificar si el área está entre 20 y 50.                                     | 5, 5                  | Área = 25, Mensaje = "El área está entre 20 y 50" |
| **Prueba 3: Área menor o igual a 20**     | Verificar si el área es menor o igual a 20.                                  | 4, 4                  | Área = 16, Mensaje = "El área es menor o igual a 20" |
| **Prueba 4: Área igual a 0**              | Verificar si el área es igual a 0 (cuando el ancho o el alto es 0).         | 0, 5                  | Área = 0, Mensaje = "El área es menor o igual a 20" |
| **Prueba 5: Área igual a 50**             | Verificar si el área es exactamente 50.                                     | 5, 10                 | Área = 50, Mensaje = "El área es mayor a 50"   |

### 2. **Pruebas para el cálculo de la circunferencia del círculo:**

| Caso de prueba                            | Descripción                                                                 | Entrada (Radio)       | Salida Esperada                                |
|-------------------------------------------|-----------------------------------------------------------------------------|-----------------------|------------------------------------------------|
| **Prueba 1: Circunferencia 0**            | Verificar la circunferencia cuando el radio es 0.                            | 0                     | Circunferencia = 0, Mensaje = "El área es menor o igual a 20" |
| **Prueba 2: Circunferencia estándar**     | Verificar el cálculo de la circunferencia para un radio de 7.               | 7                     | Circunferencia ≈ 43.982, Mensaje = "El área es menor o igual a 20" |
| **Prueba 3: Circunferencia mayor**        | Verificar la circunferencia con un radio mayor.                              | 50                    | Circunferencia ≈ 314.159, Mensaje = "El área es menor o igual a 20" |
| **Prueba 4: Radio negativo (incorrecto)** | Verificar si el sistema maneja radios negativos.                            | -5                    | Error o comportamiento no definido.           |

