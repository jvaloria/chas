INCLUDE GLOBALS.ink

->main

===main===
//TODO SFX RUIDO DE GOLPE DE PUERTA
<i>La imagen de una <color=yellow>virgen</color> me llama con una calma que incomoda.</i>
->stitch
=stitch
<i>Bajo sus pies, una nota.</i>
->stitch
->DONE

===triggerNota===
<i>¿<color=yellow>Agua bendita</color>? Tal vez esto es lo que quiso decir la vieja. O tal vez no.</i>
* [Es lo único que tengo. Se la voy a llevar.]
    // TODO Vuelve a la casa embrujada, usa el agua bendita, exorcisa la casa, se vuelve baldio, lo mide, se va, gana el juego
    ~ LoadScreenByName("11 - Casa Exorcisada")
->DONE