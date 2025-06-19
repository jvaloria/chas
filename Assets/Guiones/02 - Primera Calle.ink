INCLUDE GLOBALS.ink
VAR ciclista_text_color = "\#BDB2FB"

->main

=== main ===

~PlaySound("taxiSeVa", 0.10)
<i>Parque Chas... Tendría que haber pensado un poco más antes de aceptar venir acá, encima a esta hora.</i>
<i>¿<color=yellow>Avalos y Cádiz</color> era? A ver a dónde tengo que ir...</i>
~ LoadObject("celularmapa")
~ PlaySound("eerieWind", 0.2)
<i>Lo que faltaba, me falla el mapa y no tengo señal...</i>
~ RemoveObject("celularmapa")
+->
->queCalle

=queCalle
¿Que calle será esta?
    *???
    ->DONE
->queCalle

=== cartelCalleNext ===
~ TimedOption(0, 8)
~ LoadObject("ciclista")
~ PlaySound("BiciRing", 0.6)
->stitch2
=stitch2
Imposible leer estos carteles
*¡Flaco! ¡Esperá!
->ciclista
*{cartelCalle} [Camino. Ya estoy acá, algo me empuja a seguir.]
~ LoadScreenByName("2.1 - Calles transicion")
->DONE

=== ciclista ===
~ RemoveObject("ciclista")
~ LoadObject("ciclistaStatic")
~ LoadObject("PanelBloqueante")
Disculpame...
    * ¿Sabés cómo llegar a <color=yellow>Avalos y Cádiz?</color>
        ->ciclista_RTA
    * ¿Me prestarías el teléfono un segundo que el mío no anda?
        ->ciclista_RTA
->DONE

=== ciclista_RTA ===
<color={ciclista_text_color}>Todas las paralelas a Pampa llevan a</color> <color=yellow>la fuente.</color>
    ~ PlaySound("BiciRing", 0.8)
    ~ RemoveObject("ciclistaStatic")
    ~ RemoveObject("PanelBloqueante")
    ~ infoViejoFuente = true
¿<color=yellow>La fuente</color>? ¿y eso que tiene que ver? Gracias por nada.
    ~ LoadScreenByName("2.1 - Calles transicion")
->DONE