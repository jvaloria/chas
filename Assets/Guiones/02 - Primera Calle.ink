INCLUDE GLOBALS.ink
VAR ciclista_text_color = "\#BDB2FB"

->main

=== main ===
~PlaySound("bondiSeVa", 0.1)
Parque Chas... Tendría que haber pensado un poco más antes de aceptar venir acá, encima a esta hora.
¿<color=yellow>Avalos y Cádiz</color> era? A ver a dónde tengo que ir...
~ LoadObject("celularmapa")
~ PlaySound("eerieWind", 1)
Lo que faltaba, me falla el mapa y no tengo señal...
~ RemoveObject("celularmapa")
~ TimedOption(0, 8)
~ LoadObject("ciclista")
->stitch2
=stitch2
*¡Flaco! ¡Esperá!
->ciclista
*[Camino. Ya estoy acá, algo me empuja a seguir.]
~ LoadScreen(3)
->DONE

=== ciclista === 
~ RemoveObject("ciclista")
~ LoadObject("ciclistaStatic")
Disculpame...
    * ¿Sabés cómo llegar a <color=yellow>Avalos y Cádiz?</color>
        ->ciclista_RTA
    * ¿Me prestarías el teléfono un segundo que el mío no anda?
        ->ciclista_RTA
->DONE

=== ciclista_RTA === 
<color={ciclista_text_color}>Todas las paralelas a Pampa llevan a</color> <color=yellow>la fuente.</color>
    ~ RemoveObject("ciclistaStatic")
    ~ infoViejoFuente = true
¿<color=yellow>La fuente</color>? ¿y eso que tiene que ver? Gracias por nada.
    ->main.stitch2
->DONE