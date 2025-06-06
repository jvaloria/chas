INCLUDE GLOBALS.ink

->main

===main===
TODO SFX aguas danzantes
TODO BGM Mistico
Llego sin buscarla. No me sorprende estar acá. La sensación es más bien de retorno. 
Como si siempre hubiera sido este el destino, aunque el plan fuera otro.

Me acerco. El aire alrededor es distinto. No huele a nada, pero me limpia. 

No tengo sed, pero tengo una falta. La fuente no me invita. Me espera.

¿Qué hago?
    * [Tomo el agua. Siento que hace tiempo que estoy sediento de otra cosa.]
    ->BebeGatoBebe
    * [Me alejo. Hay algo en ese reflejo que no estoy listo para ver.]
        TODO hacer que pueda volver de la death scene
        [IMPLEMENTAR OTRO CAMINO]
        ~ LoadScreen(11)
        ->DONE
->DONE

=== BebeGatoBebe ===
No hay milagro. No hay revelación. Solo un descanso. Una apertura. Como si, por fin, pudiera quitarme el peso del alma.

La noche ya no me pesa. El mundo no me exige. No me acuerdo del trabajo. No me acuerdo del nombre. Y no me hace falta.

~ LoadScreen(10)
->DONE