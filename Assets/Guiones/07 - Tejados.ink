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
{urracaFlies:
    ~ TimedOption(0, 10)
}
<i>¿Qué hago?</i>
    *{urracaFlies} [El gorrión escapa, como marcando un camino... y yo me dejo llevar.]
        <i>El gorrión me lleva lejos, muy lejos.</i>
        <i>Y yo lo sigo.</i>
        ~ LoadScreenByName("8 - Fuente")
        ->DONE
    ->DONE
    *{!urracaFlies} [???]
        ->choicesKnot
    ->DONE
    * [Salto con todas mis fuerzas para agarrarlo]
        <i>El viento me toca la cara como si me conociera.</i>
        <i>Perdonen que no llegue.</i>
        <i>Perdonen que no avisé.</i>
        <i>Perdonen que no pude volver. O capaz… no supe cómo.</i>
        ~ textoMuerte = "<i>Caigo al piso, todo termina en un instante</i>"
        ~ LoadScreenByName("Muerte")
        ->DONE
->DONE

===urraca===
~ urracaFlies = true
~ PlaySound("flappingWings", 0.6)
->main.choicesKnot
->DONE