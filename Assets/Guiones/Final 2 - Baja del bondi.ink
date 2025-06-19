INCLUDE GLOBALS.ink

->main

===main===
<i>Esta es mi casa, no entiendo como terminé acá.</i>
    *???
    ->DONE
->DONE

===gato===
<i>Esta es mi casa, no entiendo como terminé acá.</i>
    *¿Me ayudaste vos?->stitch
=stitch
¿Venís conmigo? Es el cumpleaños de mi hijo, y él siempre quiso un gato.
~ LoadObject("Fin")
 *[Volver a intentarlo]
 ~ ResetVariables()
 ~ LoadScreenByName("0 - Menu")
->DONE