# EstructurasLineales

# Tarea 3.1: Pilas y Colas Estáticas en C# (.NET Windows Forms)

Repositorio correspondiente a la práctica de Estructuras de Datos, implementando estructuras lineales utilizando **memoria estática** (arreglos de tamaño fijo) y control manual de punteros (`top`, `front`, `rear`), sin utilizar colecciones nativas de .NET.

---

## 🛠️ Tecnologías y Requisitos Técnicos
* **Lenguaje:** C# (.NET Windows Forms)
* **Paradigma / Restricción:** Uso exclusivo de arreglos estáticos de tamaño fijo (`int[]`) definidos en tiempo de compilación.
* **Control Manual:** Punteros e índices de control implementados desde cero (`top`, `front`, `rear`, `contadorCircular`).

---

## 📋 Estructuras Implementadas

1. **Pila (Stack - LIFO):**
   * Métodos: `Push`, `Pop`, `Peek`, `isEmpty()`, `isFull()`.
   * Lógica basada en el movimiento del puntero `top`.

2. **Cola Simple (Queue - FIFO):**
   * Métodos: `Enqueue`, `Dequeue`.
   * Lógica basada en los punteros `front` y `rear`.

3. **Cola Circular:**
   * Métodos: `Enqueue Circular`, `Dequeue Circular`.
   * Lógica basada en el operador matemático de módulo/residuo (`%`) para la reutilización de espacios en memoria estática.

---

## 📸 Evidencias y Capturas de Prueba

### 1. Pruebas de Pila (Push, Pop, Peek)
*Demostración del almacenamiento en la cima (`top`), extracción de elementos y consulta con la función `Peek`.*
![Prueba Pila](<img width="1015" height="584" alt="Captura de pantalla 2026-11-06 195304" src="https://github.com/user-attachments/assets/d668ee58-0ec4-42c2-9b85-aca5b9f1f93c" />
) (<img width="1027" height="575" alt="Captura de pantalla 2026-11-06 195315" src="https://github.com/user-attachments/assets/6527392e-adf4-49ee-846e-1a756e94b2d1" />
)(<img width="1018" height="577" alt="Captura de pantalla 2026-11-06 195333" src="https://github.com/user-attachments/assets/f486ebd1-7231-48bf-9854-9d0212aa9a6f" />
)(<img width="1002" height="581" alt="Captura de pantalla 2026-11-06 195350" src="https://github.com/user-attachments/assets/fc6fa96e-bfdf-4758-b1fe-1f8f46fe3f46" />
)

### 2. Pruebas de Cola Simple (Enqueue, Dequeue)
*Demostración del llenado secuencial de la memoria estática y atención de elementos por el frente (`front`).*
![Prueba Cola Simple](<img width="1025" height="584" alt="Captura de pantalla 2026-11-06 195712" src="https://github.com/user-attachments/assets/fb47c105-a484-4503-a29a-97348cdfc614" />
)(<img width="1020" height="584" alt="Captura de pantalla 2026-11-06 195728" src="https://github.com/user-attachments/assets/99eb8ad8-a523-4b13-ac1b-aaf1e0cd3c86" />)
(<img width="995" height="572" alt="Captura de pantalla 2026-11-06 195736" src="https://github.com/user-attachments/assets/63af23ae-7937-4e2e-ad37-2c9242dd97f8" />
)
### 3. Pruebas de Cola Circular
*Demostración de la recirculación de índices mediante la operación modular en el arreglo.*
![Prueba Cola Circular](<img width="1029" height="581" alt="Captura de pantalla 2026-11-06 195904" src="https://github.com/user-attachments/assets/ff7e1e28-3877-4005-b954-0162e4d3111a" />
)

---

## 🎥 Enlace de Explicación en YouTube
* [Ver video explicativo de la práctica en YouTube]
