INCLUDE GLOBALS.ink

->main

===main===
TODO SFX de alas de pajaro
<i>No pienso. No recuerdo. Me siento.</i>

<i>Ligero. Ágil. Silencioso. Mi cuerpo responde a leyes nuevas, como si siempre hubieran estado escritas en mí.</i>
->choicesKnot
=choicesKnot
<i>¿Qué hago?</i>
    *{urracaFlies} [La urraca salta como marcando un camino… y yo me dejo llevar.]
        ->choicesKnot
    ->DONE
    *{!urracaFlies} [???]
        ->choicesKnot
    ->DONE
    * [Salto con todas mis fuerzas]
        TODO hacer que pueda volver de la death scene
        [IMPLEMENTAR MUERTE]
        ~ LoadScreen(12)
        ->DONE
    * [Mejor me bajo y vuelvo para Triunvirato]
        TODO hacer que pueda volver de la death scene
        [IMPLEMENTAR OTRO CAMINO]
        ~ LoadScreen(8)
        ->DONE
->DONE

===urraca===
~ urracaFlies = true
->main.choicesKnot
->DONE