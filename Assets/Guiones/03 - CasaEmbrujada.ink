INCLUDE GLOBALS.ink
VAR vieja_text_color = "\#FF9E9E"

->main

===main===
<i>No sé si llegué hasta ella por decisión propia o por arrastre.</i>
->yahora
=yahora
<i>¿Qué hago?</i>
    *{tuxedoCatMansion} [¿Maullidos? Suenan cerca. Mejor voy a ver qué pasa.]
        ->loadParada186
        ->DONE
    *{!tuxedoCatMansion} [???]
        ->DONE
    *{viejaMansionPizza} [Triunvirato es para la izquierda, voy para allá. Alguien tiene que haber.]
        ->loadParada186
        ->DONE
    *{!viejaMansionPizza} [???]
        ->DONE
    *{viejaMansionFuente} [Si sigo derecho voy a la fuente, el de la bici me mandó para ahí]
        ->loadParada186
        ->DONE
    *{!viejaMansionFuente} [???]
        ->DONE
    +->
    ->yahora
->yahora

===loadParada186===
~ LoadScreenByName("4 - Parada186")
->DONE
->main.yahora

===rayo===
<i>En la reja, aparece un gato que me mira como si me conociera. No se mueve. Me observa. Y siento que hay un juicio, pero sin condena.</i>
->main.yahora

===tuxedoCat===
¡Ey, esperá!
->main.yahora

===vieja===
~ LoadObject("PanelBloqueante")
<color={vieja_text_color}>Por fin llega la pizza! Por qué tardaste tanto?</color>
    *Perdón, no soy el del delivery. ¿me dice cómo llego a <color=yellow>Avalos y Cádiz</color>, por favor?
        -> viejaAvalosyCadiz
    *{infoViejoFuente}Perdón, no soy el del delivery. ¿me dice cómo llego a <color=yellow>la fuente</color>, por favor?
        -> viejaFuente


=== viejaAvalosyCadiz ===
<color={vieja_text_color}> ¿Eh? ¿perdiste la pizza? trae otra y te digo.</color>
    *Bueno, ¿dónde es la pizzería? (ahí capaz me dicen)
        Doblá acá a la izquierda, hacia Triunvirato.
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        ~ RemoveObject("PanelBloqueante")
        -> break_and_go
    *No soy el del delivery dije. por favor.
        <color={vieja_text_color}>Traeme la pizza te dije. La pizzería es doblando a la izquierda, hacia Triunvirato.</color>
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        ~ RemoveObject("PanelBloqueante")
        -> break_and_go


=== viejaFuente ===
<color={vieja_text_color}> ¿Eh? ¿perdiste la pizza? trae otra y te digo.</color>
    *bueno, ¿dónde es la pizzería? (ahí capaz me dicen)
        <color={vieja_text_color}>doblá acá a la izquierda, hacia Triunvirato.</color>
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        ~ RemoveObject("PanelBloqueante")
        -> break_and_go
    *que no soy el del delivery dije. por favor <color=yellow>la fuente</color>
        <color={vieja_text_color}>Meh... Seguí derecho, está por ahí.</color>
        ~ viejaMansionFuente = true
        ~ RemoveObject("Vieja")
        ~ RemoveObject("PanelBloqueante")
        -> break_and_go

=== break_and_go ===
-> main.yahora
