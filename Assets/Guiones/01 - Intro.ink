INCLUDE GLOBALS.ink
VAR chofer_text_color = "\#ADF0C7"

->main

===main===
<i>Nunca entiendo del todo cómo funcionan los favores en mi trabajo.</i>
<i>Esta noche, cuando me dijeron que tenía que ir a Parque Chas urgente a medir un terreno, no lo discutí.</i>
<i>Fingí interés. Tomé los planos. Guardé el láser. Me puse la campera buena y me subí al taxi sin pensar demasiado.</i>
<i>Es el cumpleaños de mi hijo. Prometí llegar para soplar las velitas. Prometí tantas cosas que ya no me creo ni a mí mismo.</i>

<color={chofer_text_color}>Parque Chas. Hasta acá llego flaco. No entro.</color>
<color={chofer_text_color}>BAJATE RAPIDO que no me gusta quedarme mucho acá.</color>
->stitch
=stitch
    *¿Por qué? No deben faltar muchas cuadras...
        ->TacheroAnnoyed
    *[Hay lugares que no aceptan explicaciones. Bajo.]
        ~ LoadScreenByName("2 - Primera Calle")
->DONE

=== TacheroAnnoyed ===
<color={chofer_text_color}>¡Bajate ya! ¿No sabés que los taxis no entramos en Parque Chas?</color>
<i>Bajo. Y cuando se cierra la puerta detrás de mí, siento que algo también se cierra adentro.</i>
~ LoadScreenByName("2 - Primera Calle")
->DONE