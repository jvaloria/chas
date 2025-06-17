INCLUDE GLOBALS.ink
VAR vieja_text_color = "\#FF9E9E"

->main

===main===
<i>No sé si llegué hasta ella por decisión propia o por arrastre.</i>
->yahora
=yahora
<i>¿Qué hago?</i>
    *{tuxedoCatMansion} [¿Maullidos? Suenan cerca. Mejor voy a ver qué pasa.]
        ~ LoadScreenByName("4 - Parada186")
        ->DONE
    *{!tuxedoCatMansion} [???]
        ->DONE
    *{viejaMansionIglesia} [Camino siguiendo algo que podría ser fe, o simplemente impulso.]
        <i>Las luces de la torre me guían como un faro que nunca prometió salvar a nadie.</i>
        ~ LoadScreenByName("9 - Iglesia")
        ->DONE
    *{!viejaMansionIglesia} [???]
        ->DONE
    *{viejaMansionBrujula} [Camino sin convicción.]
        // TODO armar escena de gato CALICO que lleva a brujula y fin
        <i>Necesito encontrar Ávalos y Cádiz. No puede ser tan difícil</i>
        <i>Pero el barrio me rodea. Estoy atrapado, no por muros, sino por algo que me quiere adentro.</i>
        //->loadParada186
        ->DONE
    *{!viejaMansionBrujula} [???]
        ->DONE
    +->
    ->yahora
->yahora

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
        ~ viejaMansionBrujula = true
        -> viejaBrujula



=== viejaBrujula ===
<color={vieja_text_color}>Si no sos quien decis que sos, salí de mi casa y camina para Triunvirato.</color>
<i>No hay odio en su tono. Pero tampoco hay lugar para mí.</i>
~ RemoveObject("Vieja")
~ RemoveObject("PanelBloqueante")
-> break_and_go

=== break_and_go ===
-> main.yahora
