EXTERNAL LoadObject(string object)
EXTERNAL RemoveObject(string object)
EXTERNAL TimedOption(int optionNumber, int timeForOption)
EXTERNAL LoadScreen(int screenNumber)
EXTERNAL PlaySound(string soundToPlay)

->main

=== main ===
~PlaySound("BondiSeVa")
Parque Chas... Tendría que haber pensado un poco más antes de decir que sí a este asado. Los tacheros no me querían traer y el del bondi casi me baja a patadas. Avalos y Cádiz era? Aver a dónde tengo que ir...
~ LoadObject("celularmapa")
~ PlaySound("Viento")
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
    ~ LoadScreen(2)
->DONE


=== ciclista === 
~ RemoveObject("ciclista")
~ LoadObject("ciclistaStatic")
Disculpa...
    * Sabes cómo llegar a Avalos y Cádiz?
        Todas las paralelas a Pampa llevan a la fuente 
        ~ RemoveObject("ciclistaStatic")
        ->main.stitch2
    * Me prestarías el teléfono un segundo que el mío no anda?
        Todas las paralelas a Pampa llevan a la fuente 
        ~ RemoveObject("ciclistaStatic")
        ->main.stitch2
->DONE