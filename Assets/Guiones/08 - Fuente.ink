INCLUDE GLOBALS.ink

->main

===main===
TODO SFX aguas danzantes
TODO BGM Mistico
<i>Llego sin buscarla. No me sorprende estar acá. La sensación es más bien de retorno.</i>
<i>Como si siempre hubiera sido este el destino, aunque el plan fuera otro.</i>

<i>Me acerco. El aire alrededor es distinto. No huele a nada, pero me limpia.</i>

<i>No tengo sed, pero tengo una falta. La fuente no me invita. Me espera.</i>

<i>¿Qué hago?</i>
    * [Tomo el agua. Siento que hace tiempo que estoy sediento de otra cosa.]
    ->BebeGatoBebe
    * [Me alejo. Hay algo en ese reflejo que no estoy listo para ver.]
        TODO hacer que pueda volver de la death scene
        [IMPLEMENTAR OTRO CAMINO]
        ~ LoadScreen(11)
        ->DONE
->DONE

=== BebeGatoBebe ===
<i>No hay milagro. No hay revelación. Solo un descanso. Una apertura. Como si, por fin, pudiera quitarme el peso del alma.</i>

<i>La noche ya no me pesa. El mundo no me exige. No me acuerdo del trabajo. No me acuerdo del nombre. Y no me hace falta.</i>

~ LoadScreen(10)
->DONE