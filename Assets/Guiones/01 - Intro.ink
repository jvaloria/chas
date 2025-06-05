INCLUDE GLOBALS.ink
VAR chofer_text_color = "\#ADF0C7"

->main

===main===
Nunca entiendo del todo cómo funcionan los favores en mi trabajo. 
Hay pedidos que se hacen con sonrisas, y hay exigencias que vienen disfrazadas de oportunidades. 
Esta noche, cuando me dijeron que tenía que ir a Parque Chas urgente a medir un terreno, no lo discutí. 
Fingí interés. Tomé los planos. Guardé el láser. Me puse la campera buena y me subí al taxi sin pensar demasiado.

Es el cumpleaños de mi hijo. Prometí llegar para soplar las velitas. Prometí tantas cosas que ya no me creo ni a mí mismo.

<color={chofer_text_color}>Parque Chas. Hasta acá llego flaco. No entro.</color>
<color={chofer_text_color}>BAJATE RAPIDO que no me gusta quedarme mucho acá.</color>
->stitch
=stitch
    *¿Por qué? No deben faltar muchas cuadras... 
        ->TacheroAnnoyed
    *[No pregunto por qué. En el fondo, ya lo sé. Hay lugares que no aceptan explicaciones. Bajo.]
        ~ LoadScreen(2)
->DONE

=== TacheroAnnoyed ===
<color={chofer_text_color}>¡Bajate ya! ¿No sabés que los tacheros no entramos en Parque Chas?</color>
Bajo. Y cuando se cierra la puerta detrás de mí, siento que algo también se cierra adentro.
~ LoadScreen(2)
->DONE