# NaveGame

NaveGame es un juego 2D de combate espacial donde controlas una nave y enfrentas a un enemigo en una batalla directa.

---

## Gameplay

- Controla tu nave con las **flechas del teclado**
- Dispara usando la **barra espaciadora**
- Esquiva los ataques enemigos mientras intentas destruirlo

El enemigo se mueve automáticamente de izquierda a derecha y también dispara misiles, creando un combate dinámico.

---

## Sistema de vidas

- Tanto el jugador como el enemigo tienen **5 vidas**
- Cada impacto de misil reduce una vida
- El juego termina cuando:
  - El enemigo pierde todas sus vidas → *Ganaste*
  - El jugador pierde todas sus vidas → *Perdiste*

---

## Tecnologías utilizadas

- Unity (2D)
- C#
- Input System (teclado)
- Física 2D (colisiones con `OnTriggerEnter2D`)
- UI con Slider (barras de vida)

---

## Características técnicas

- Movimiento limitado dentro del fondo del juego
- Sistema de disparo con instanciación de proyectiles
- Detección de colisiones optimizada (evita daño múltiple)
- Uso combinado de **scripting tradicional y visual scripting** para lógica del juego

---

## Versión Web

El juego está preparado para ejecutarse en navegador mediante itch.io.

---
