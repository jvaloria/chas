INCLUDE GLOBALS.ink

->main

===main===
Camino junto al gato. Ya no me apura la meta, ni el reloj. 
Siento que cada paso me aleja de la persona que fui esta mañana. Esa persona tan llena de deberes que ya no sabía cómo desear.

TODO SFX Ladrido
Se me cierra el pecho, como si me hubieran recordado algo que había preferido olvidar.

<color=red>Grrrrrrrrrrrrrrrr</color>
    * [¡Rápido, abajo de ese auto así no me mata!]
        ->BajoAuto
    * ¡Ese árbol! Si me subo no me va a alcanzar
        ... Ya no escucho nada, parece que se fue ...
        Me viene una urgencia por mirar desde más arriba. 
        Como si, desde una altura, pudiera entender mi lugar en todo esto.
        ~ LoadScreen(7)
        ->DONE
    * Me arrinconó, es el o yo...
        TODO hacer que pueda volver de la death scene
        TODO [IMPLEMENTAR MUERTE]
        ~ LoadScreen(12)
        ->DONE
->DONE

===BajoAuto===
... Ya no escucho nada, parece que se fue ...
* Mejor me apuro a salir de acá y seguir viaje antes de que vuelva
    Ya no siento miedo. Siento una forma de expansión. Como si al dejar de apurarme empezara a ver.
    
    Me doy cuenta de que no busco una salida. Busco sentido. O algo parecido. 
    
    Me viene una urgencia por mirar desde más arriba. 
    No sé si para orientarme o para comprobar que todo esto es real. Pero lo necesito. 
    
    Esa necesidad no es lógica, es física. Como un hambre. Como si, desde una altura, pudiera entender mi lugar en todo esto.
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