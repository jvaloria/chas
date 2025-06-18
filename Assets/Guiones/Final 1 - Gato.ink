INCLUDE GLOBALS.ink

->main

===main===
<i>Soy un gato naranja.</i>
<i>Soy libre.</i>
<i>Y por fin, estoy en casa.</i>
// ~ RemoveObject("DialoguePanel")
// ~ RemoveObject("arrowIcon")
~ LoadObject("Fin")
 *[Volver a intentarlo]
 ~ ResetVariables()
 ~ LoadScreenByName("0 - Menu")
->DONE