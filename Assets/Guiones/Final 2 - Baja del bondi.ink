INCLUDE GLOBALS.ink

->main

===main===
<i>Esta es mi casa, no entiendo como terminé acá</i>
    *???
    ->DONE
->DONE

===gato===
<i>Esta es mi casa, no entiendo como terminé acá</i>
    *[Me ayudaste vos?]->stitch
=stitch
Venís conmigo? Es el cumpleaños de mi hijo, y él siempre quiso un gato
TODO implementar escena de fin o usar esta
~ RemoveObject("DialoguePanel")
~ RemoveObject("arrowIcon")
~ LoadObject("Fin")
* hack
->END