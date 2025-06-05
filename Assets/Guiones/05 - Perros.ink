INCLUDE GLOBALS.ink

->main

===main===
<color=red>Grrrrrrrrrrrrrrrr</color>
    * ¡Rápido, abajo de ese auto así no me mata!
        ->BajoAuto
    * ¡Ese árbol! Si me subo no me va a alcanzar
        ... Ya no escucho nada, parece que se fue ...
        ~ LoadScreen(7)
        ->DONE
    * Me arrinconó, es el o yo...
        TODO hacer que pueda volver de la death scene
        [IMPLEMENTAR MUERTE]
        ~ LoadScreen(7)
        ->DONE
->DONE

===BajoAuto===
... Ya no escucho nada, parece que se fue ...
* Mejor me apuro a salir de acá y seguir viaje antes de que vuelva
    Está hermosa la noche, con la luz de la luna se ve todo mucho mejor
    Si me subo a este árbol capaz veo para donde está la fuente
     ~ LoadScreen(7)
    ->DONE
* Hay una alcantarilla
    TODO Va a laberinto
    [IMPLEMENTAR LABERINTO]
    //~ LoadScreen(laberinto)
    // temporalmente dejo esto para poder elegir la otra opcion
    ->BajoAuto
    ->DONE
->DONE