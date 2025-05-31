INCLUDE GLOBALS.ink
VAR chofer_text_color = "\#ADF0C7"

->main

===main===
<color={chofer_text_color}>¡PARQUE CHAAAS!</color>
<color={chofer_text_color}>¡BAJATE RAPIDO! No me gusta quedarme mucho acá.</color>
->stitch
=stitch
    *¿Pero quién te crees que sos para apurarme? ¡Todos iguales los choferes!
        ->ColectiveroAnnoyed1
    *¡Tomá! ¡A ver si te gusta este timbrazo!
        TODO Ejecutar SFX de timbrazo
        ->ColectiveroAnnoyed2
    *Mejor me bajo... 
    ~ LoadScreen(2)
->DONE

=== ColectiveroAnnoyed1 ===
<color={chofer_text_color}>¡Bajate ya o me voy!</color>
->main.stitch

=== ColectiveroAnnoyed2 ===
<color={chofer_text_color}>¡Tenes 3 segundos para bajarte! ¡Uno.. Dos..!</color>
->main.stitch