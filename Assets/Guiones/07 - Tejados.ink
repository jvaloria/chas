INCLUDE GLOBALS.ink

->main

===main===
<i>Desde lo alto, siento algo. No lo veo, lo percibo. Como una hebra de pensamiento que no es mía, pero que igual me lleva.</i>
~ PlaySound("flappingWings", 0.6)
~ LoadObject("Sparrow")
<i>Es un gorrión. Salta de un lado al otro. Me guía sin mirarme.</i>

<i>Ligero. Ágil. Silencioso. Mi cuerpo responde a leyes nuevas, como si siempre hubieran estado escritas en mí.</i>
->choicesKnot
=choicesKnot
<i>¿Qué hago?</i>
    *{urracaFlies} [El gorrión escapa, como marcando un camino... y yo me dejo llevar.]
        <i>El gorrión me lleva lejos, muy lejos.</i>
        <i>Y yo lo sigo.</i>
        ~ LoadScreen(9)
        ->DONE
    ->DONE
    *{!urracaFlies} [???]
        ->choicesKnot
    ->DONE
    * [Salto con todas mis fuerzas para agarrarlo]
        TODO [IMPLEMENTAR MUERTE]
        TODO hacer que pueda volver de la death scene
        ~ LoadScreen(11)
        ->DONE
->DONE

===urraca===
~ urracaFlies = true
~ PlaySound("flappingWings", 0.6)
->main.choicesKnot
->DONE