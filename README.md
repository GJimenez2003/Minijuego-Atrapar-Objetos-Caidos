# Atrapar Objetos Caídos

Atrapar Objetos Caídos es un videojuego sencillo y educativo diseñado para aplicar los principios de la programación orientada a objetos (OOP) y el patrón Singleton en un entorno de desarrollo real, utilizando Unity 3D. El objetivo del juego es controlar una canasta que se mueve de izquierda a derecha para atrapar objetos que caen desde la parte superior de la pantalla. Cada objeto atrapado incrementa la puntuación del jugador, y se guarda la puntuación más alta utilizando el patrón Singleton.

## Estructura del Proyecto

- **Assets/**
  - **Scripts/**
    - `CanastaController.cs` - Controla el movimiento de la canasta.
    - `GeneradorObjetos.cs` - Genera los objetos caídos de forma aleatoria.
    - `Puntuacion.cs` - Gestiona la puntuación del jugador y las colisiones.
    - `PuntuacionAlta.cs` - Gestiona la puntuación más alta utilizando el patrón Singleton.
    - `MainMenu.cs` - Gestiona la UI del menú principal.
  - **Prefabs/**
    - `ObjetoCaido.prefab` - Prefab de los objetos que caen.
  - **Scenes/**
    - `MainMenu.unity` - Escena del menú principal.
    - `GameScene.unity` - Escena del juego principal.
  - **UI/**
    - `PuntuacionText` - Texto que muestra la puntuación actual.
    - `PuntuacionAltaText` - Texto que muestra la puntuación más alta.

## Descripción de los Componentes del Videojuego

1. **Configuración del Proyecto en Unity**
    - Crear un proyecto nuevo, configurar la escena con una cámara y un plano base para el juego.

2. **Configuración del Proyecto en Git**
    - Usar GitHub para subir el proyecto en un repositorio.

3. **Creación de Menú Principal**
    - Crear una UI de menú principal para poder empezar el juego, seleccionar el color de la canasta.

4. **Creación de Modelos y Elementos del Juego**
    - Utilizar modelos 3D nativos de Unity para representar la canasta (jugador), los objetos caídos y el suelo.

5. **Programación del Movimiento de la Canasta**
    - Implementar el control del jugador para mover la canasta de izquierda a derecha.

6. **Programación de la Caída de los Objetos**
    - Implementar la lógica para que los objetos caídos aparezcan aleatoriamente y caigan desde la parte superior de la pantalla.

7. **Detección de Colisiones y Aumento de Puntuación**
    - Detectar cuando la canasta atrapa un objeto caído y aumentar la puntuación del jugador.

8. **Integración del Patrón Singleton para Guardar las Puntuaciones Más Altas**
    - Utilizar el patrón Singleton para guardar y actualizar la puntuación más alta del juego.

9. **Configuración de la Interfaz de Usuario**
    - Añadir elementos de la UI para mostrar la puntuación actual y la puntuación más alta.

## Comunicación entre Componentes

- **Movimiento de la Canasta:** El script `CanastaController` controla el movimiento de la canasta.
- **Generación y Caída de Objetos:** El script `GeneradorObjetos` instancia objetos caídos.
- **Detección de Colisiones:** El script `Puntuacion` incrementa la puntuación y destruye los objetos atrapados.
- **Guardado de Puntuación Alta:** El script `PuntuacionAlta` guarda la puntuación más alta y la actualiza si es necesario.


