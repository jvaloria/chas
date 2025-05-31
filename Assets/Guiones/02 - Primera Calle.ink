INCLUDE GLOBALS.ink

->main

=== main ===
~PlaySound("bondiSeVa")
...
Parque Chas... Tendría que haber pensado un poco más antes de decir que sí a este <color=yellow>asado</color>. Los tacheros no me querían traer y el del bondi casi me baja a patadas. <color=yellow>Avalos y Cádiz</color> era? Aver a dónde tengo que ir...
~ LoadObject("celularmapa")
~ PlaySound("eerieWind")
Lo que faltaba: me falla el mapa y no tengo señal...
~ RemoveObject("celularmapa")
~ TimedOption(0, 8)
~ LoadObject("ciclista")
->stitch2
=stitch2
Y ahora que hago?
    *Detener al ciclista
    ->ciclista
    *Seguir hasta la esquina
    ~ LoadScreen(3)
->DONE


=== ciclista === 
~ RemoveObject("ciclista")
~ LoadObject("ciclistaStatic")
Disculpame...
    * Sabes cómo llegar a <color=yellow>Avalos y Cádiz?</color>
        Todas las paralelas a Pampa llevan a <color=yellow>la fuente</color>
        ~ RemoveObject("ciclistaStatic")
        ~ infoViejoFuente = true
        Y qué tiene que ver <color=yellow>la fuente</color>? Están todos <color=yellow>locos</color> hoy...
        ->main.stitch2
    * Me prestarías el teléfono un segundo que el mío no anda?
        Todas las paralelas a Pampa llevan a <color=yellow>la fuente</color>
        ~ RemoveObject("ciclistaStatic")
        ~ infoViejoFuente = true
        Y qué tiene que ver <color=yellow>la fuente</color>? Están todos <color=yellow>locos</color> hoy...
        ->main.stitch2
->DONE