INCLUDE GLOBALS.ink
VAR vieja_text_color = "\#FF9E9E"

->main

===main===
~ LoadObject("Vieja")
<i>Vuelvo. La encuentro afuera, como si nunca se hubiera movido.</i>
    *[<i>Le doy el agua.</i>]
    ~ PlaySound("exorcismo", 0.5)
    ->main.stitch
~ RemoveObject("Vieja")
// TODO Fade to white
// TODO [LA CASA DESAPARECE Y EN SU LUGAR APARECE UN TERRENO]
=stitch

<i>Apenas la sostiene entre las manos, la casa... desaparece. No se derrumba. No se esfuma. Simplemente deja de estar.</i>
~ LoadObject("BlackPlane")
~ RemoveObject("MovieBG")
~ RemoveObject("Vieja")
~ FadeOutObject("BlackPlane", 2)
<i>Frente a mí, la casa derrumbada. Justo como decía la orden de trabajo.</i>
<i>Mido rápido. El láser funciona. Los números tienen sentido. Pero yo no.</i>
<i>Termino y me voy. No corro, pero camino con ansiedad.</i>
<i>Todavía estoy a tiempo de llegar a casa antes de volver a perderme.</i>
~ LoadObject("Fin")
 *[Volver a intentarlo]
 ~ ResetVariables()
 ~ LoadScreenByName("0 - Menu")
 ->DONE
