INCLUDE GLOBALS.ink

->main

===main===
<i>Pero algo se queda adentro.</i>
<i>No sabría decir qué.</i>
// ~ RemoveObject("DialoguePanel")
// ~ RemoveObject("arrowIcon")
~ LoadObject("Fin")
 *[Volver a intentarlo]
 ~ ResetVariables()
 ~ LoadScreenByName("0 - Menu")
 ->DONE