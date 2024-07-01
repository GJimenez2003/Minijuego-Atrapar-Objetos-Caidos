# Atrapar Objetos Caídos

Un juego educativo en Unity 3D para aprender programación orientada a objetos (POO) y el patrón Singleton.

## Descripción

"Atrapar Objetos Caídos" es un juego simple pero divertido donde controlas una canasta que se mueve de izquierda a derecha para atrapar objetos que caen desde la parte superior de la pantalla. Cada objeto atrapado aumenta tu puntuación, y el juego guarda tu puntuación más alta utilizando el patrón Singleton.

Este proyecto es ideal para estudiantes que están aprendiendo los conceptos de POO y patrones de diseño en Unity. El código está bien estructurado y comentado para facilitar su comprensión.

## Características

*   **Mecánica de Juego Simple:** Controla la canasta con las teclas de flecha izquierda y derecha para atrapar objetos que caen.
*   **Sistema de Puntuación:** Gana puntos por cada objeto atrapado.
*   **Puntuación Más Alta:** El juego guarda tu mejor puntuación y la muestra en el menú principal.
*   **Selección de Color:** Elige el color de tu canasta antes de comenzar a jugar.
*   **Persistencia de Datos:** Utiliza archivos JSON para guardar la puntuación más alta.

## Cómo Jugar

1.  **Clonar el Repositorio:** `git clone https://github.com/GJimenez2003/Minijuego-Atrapar-Objetos-Caidos`
2.  **Abrir en Unity:** Abre el proyecto en Unity 3D.
3.  **Seleccionar Color:** En el menú principal, elige el color de tu canasta.
4.  **Jugar:** Haz clic en "Jugar" para comenzar la partida.
5.  **Controles:** Usa las teclas de flecha izquierda y derecha para mover la canasta.

## Estructura del Proyecto

*   **Assets:** Contiene todos los recursos del juego (scripts, modelos, materiales, etc.).
*   **Scenes:** Contiene las escenas del juego (MenuScene, GameScene).
*   **Scripts:** Contiene los scripts C# del juego (`Canasta`, `GeneradorObjetos`, `Puntuacion`, `HighScoreManager`, `MenuManager`, `ColorManager`).

## Contribuciones

¡Las contribuciones son bienvenidas! Si encuentras algún error o tienes alguna sugerencia para mejorar el juego, no dudes en abrir un issue o enviar un pull request.

