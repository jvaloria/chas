INCLUDE GLOBALS.ink
  
->main

===main===
No me gusta nada este barrio oscuro... ¿Cómo se supone que llegue si no puedo encontrar la calle?
->yahora
=yahora
Y ahora qué hago? que casa más rara...
    *{tuxedoCatMansion} Ya fue, sigo a ese gato a ver qué encuentro.
    ~ LoadScreen(4) 
    ->DONE
    *{viejaMansionFuente} Si sigo derecho voy a la fuente, el de la bici me mandó para ahí
     ~ LoadScreen(4)
    ->DONE
    *{viejaMansionPizza} La avenida Triunvirato es para la izquierda, voy para allá.
    ~ LoadScreen(5)
    ->DONE
    +->
    ->yahora
->yahora

===rayo===
WAGH!! Qué fue eso?
->main.yahora

===tuxedoCat===
A dónde va ese gato con galera?->main.yahora

=== vieja ===
Por fin llega la pizza! Por qué tardaste tanto?
    *Perdón, no soy el del delivery. Estoy perdido, me dice cómo llego a <color=yellow>Avalos y Cádiz</color>, por favor?
        -> viejaAvalosyCadiz
    *{infoViejoFuente}Perdón, no soy el del delivery. Estoy perdido, me dice cómo llego a <color=yellow>la fuente</color>, por favor?
        -> viejaFuente


=== viejaAvalosyCadiz ===
eh? ¿perdiste la pizza? trae otra y te digo.
    *bueno, ¿dónde es la pizzería? (ahí capaz me dicen)
        doblá acá a la izquierda, hacia Triunvirato.
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        -> break_and_go
    *que no soy el del delivery dije. por favor
        pizza dije. la pizzería es doblando a la izquierda, hacia Triunvirato.
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        -> break_and_go


=== viejaFuente ===
eh? ¿perdiste la pizza? trae otra y te digo.
    *bueno, ¿dónde es la pizzería? (ahí capaz me dicen)
        doblá acá a la izquierda, hacia Triunvirato.
        ~ viejaMansionPizza = true
        ~ RemoveObject("Vieja")
        -> break_and_go
    *que no soy el del delivery dije. por favor <color=yellow>la fuente</color>
        Meh... Seguí derecho, está por ahí.
        ~ viejaMansionFuente = true
        ~ RemoveObject("Vieja")
        -> break_and_go


=== break_and_go ===
-> main.yahora
