INCLUDE GLOBALS.ink

->main

===main===
<i>Desde lo alto, siento algo. No lo veo, lo percibo. Como una hebra de pensamiento que no es mía, pero que igual me lleva.</i>
TODO SFX de alas de pajaro
<i>Es una urraca. Salta de un lado al otro. Me guía sin mirarme.</i>

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
    /** [Mejor me bajo y vuelvo para Triunvirato]
        TODO hacer que pueda volver de la death scene
        [IMPLEMENTAR OTRO CAMINO]
        ~ LoadScreen(8)
        ->DONE*/
->DONE

===urraca===
~ urracaFlies = true
->main.choicesKnot
->DONE