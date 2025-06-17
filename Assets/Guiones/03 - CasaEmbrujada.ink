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
    *{viejaMansionIglesia} [Camino siguiendo algo que podría ser fe, o simplemente impulso.]
        <i>Las luces de la torre me guían como un faro que nunca prometió salvar a nadie.</i>
        TODO armar escena de iglesia
        ~ LoadScreenByName("9 - Iglesia")
        ->DONE
    *{!viejaMansionIglesia} [???]
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
<color={vieja_text_color}>Te estaba esperando. ¿Por qué tardaste tanto?</color>
    *No se a quién espera. Estoy buscando <color=yellow>Ávalos y Cádiz.</color>
        -> viejaAvalosyCadiz
    *{infoViejoFuente}Perdón, no soy el del delivery. ¿me dice cómo llego a <color=yellow>la fuente</color>, por favor?
        -> viejaFuente


=== viejaAvalosyCadiz ===
<color={vieja_text_color}>Esto es <color=yellow>Ávalos y Cádiz</color>. Como te decía... te estaba esperando.</color>
<i>No sé si me confunde con alguien, o si esto ya no tiene lógica.</i>
    *No puede ser, acá debería haber un terreno baldío. Me mandaron a medirlo.
        <color={vieja_text_color}>Acá no hay ningún terreno. Solo almas en pena.</color>
        <color={vieja_text_color}>Si alguna vez querés salir de Parque Chas, podés ir a rezar a <color=yellow>la iglesia</color>.</color>
        ~ viejaMansionIglesia = true
        ~ RemoveObject("Vieja")
        ~ RemoveObject("PanelBloqueante")
        La <color=yellow>iglesia...</color>  Creo haber visto una torre hace un rato, pero ya no confío en lo que recuerdo.
        -> break_and_go
    *No entiendo por qué me estaba esperando, no soy esa persona.
        <color={vieja_text_color}> FALTA IMPLEMENTAR </color>
        //~ viejaMansionIglesia = true
        ~ RemoveObject("Vieja")
        ~ RemoveObject("PanelBloqueante")
        -> break_and_go


=== viejaFuente ===
<color={vieja_text_color}> ¿Eh? ¿perdiste la pizza? trae otra y te digo.</color>
    *bueno, ¿dónde es la pizzería? (ahí capaz me dicen)
        <color={vieja_text_color}>doblá acá a la izquierda, hacia Triunvirato.</color>
        //~ viejaMansionPizza = true
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
