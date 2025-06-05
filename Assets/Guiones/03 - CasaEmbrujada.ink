INCLUDE GLOBALS.ink
VAR vieja_text_color = "\#FF9E9E"  

->main

===main===
No me gusta nada este barrio oscuro... ¿Cómo voy a llegar si no encuentro la calle?
->yahora
=yahora
¿Y ahora qué hago? que casa más rara...
    *{tuxedoCatMansion} ¿Maullidos? Vienen de acá a la vuelta, ¿será el gato de recién?
    ~ LoadScreen(4) 
    ->DONE
    *{viejaMansionFuente} Si sigo derecho voy a la fuente, el de la bici me mandó para ahí
     ~ LoadScreen(4)
    ->DONE
    *{viejaMansionPizza} La avenida Triunvirato es para la izquierda, voy para allá. Alguien tiene que haber.
    ~ LoadScreen(4)
    ->DONE
    +->
    ->yahora
->yahora

===rayo===
¡¡WAGH!! No decía que iba a llover..
Qué gato elegante, ¿siempre estuviste ahí? 
->main.yahora

===tuxedoCat===
¡Ey, espera!
->main.yahora

===vieja===
<color={vieja_text_color}>Por fin llega la pizza! Por qué tardaste tanto?</color>
    *Perdón, no soy el del delivery. Estoy perdido, ¿me dice cómo llego a <color=yellow>Avalos y Cádiz</color>, por favor?
        -> viejaAvalosyCadiz
    *{infoViejoFuente}Perdón, no soy el del delivery. Estoy perdido, ¿me dice cómo llego a <color=yellow>la fuente</color>, por favor?
        -> viejaFuente


=== viejaAvalosyCadiz ===
<color={vieja_text_color}> ¿Eh? ¿perdiste la pizza? trae otra y te digo.</color>
    *bueno, ¿dónde es la pizzería? (ahí capaz me dicen)
        doblá acá a la izquierda, hacia Triunvirato.
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        -> break_and_go
    *que no soy el del delivery dije. por favor
        <color={vieja_text_color}>Traeme la pizza te dije. La pizzería es doblando a la izquierda, hacia Triunvirato.</color>
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        -> break_and_go


=== viejaFuente ===
<color={vieja_text_color}> ¿Eh? ¿perdiste la pizza? trae otra y te digo.</color>
    *bueno, ¿dónde es la pizzería? (ahí capaz me dicen)
        <color={vieja_text_color}>doblá acá a la izquierda, hacia Triunvirato.</color>
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        -> break_and_go
    *que no soy el del delivery dije. por favor <color=yellow>la fuente</color>
        <color={vieja_text_color}>Meh... Seguí derecho, está por ahí.</color>
        ~ viejaMansionFuente = true
        ~ RemoveObject("Vieja")
        -> break_and_go

=== break_and_go ===
-> main.yahora
