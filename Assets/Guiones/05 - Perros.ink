INCLUDE GLOBALS.ink

->main

===main===
<i>Camino junto al gato. Ya no me apura la meta, ni el reloj.</i>
<i>Siento que cada paso me aleja de la persona que fui esta mañana. Esa persona tan llena de deberes que ya no sabía cómo desear.</i>

TODO SFX Ladrido
<i>Se me cierra el pecho, como si me hubieran recordado algo que había preferido olvidar.</i>

<color=red>Grrrrrrrrrrrrrrrr</color>
    * [¡Rápido, abajo de ese auto así no me mata!]
        ->BajoAuto
    * [¡Ese árbol! Si me subo no me va a alcanzar]
        <i>Trepé lo más rápido que pude y cuando llegué arriba ya no escucho nada...</i>
        <i>Me viene una urgencia por mirar desde más arriba.</i>
        <i>Como si, desde una altura, pudiera entender mi lugar en todo esto.</i>
        ~ LoadScreen(7)
        ->DONE
    * [Me arrinconó, es el o yo...]
        TODO hacer que pueda volver de la death scene
        TODO [IMPLEMENTAR MUERTE]
        ~ LoadScreen(12)
        ->DONE
->DONE

===BajoAuto===
<i>Me oculté lo más rápido que pude. Parece que se fue...</i>
* [Mejor sigo viaje antes de que vuelva]
    <i>Ya no siento miedo. Como si al dejar de apurarme empezara a ver.</i>
    <i>Me viene una urgencia por mirar desde más arriba.</i>
    <i>Como si, desde una altura, pudiera entender mi lugar en todo esto.</i>
     ~ LoadScreen(7)
    ->DONE
* [Hay una alcantarilla]
    TODO Va a laberinto
    [IMPLEMENTAR LABERINTO]
    //~ LoadScreen(laberinto)
    // temporalmente dejo esto para poder elegir la otra opcion
    ->BajoAuto
    ->DONE
->DONE