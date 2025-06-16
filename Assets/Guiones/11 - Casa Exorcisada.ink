INCLUDE GLOBALS.ink
VAR vieja_text_color = "\#FF9E9E"

->main

===main===
~ LoadObject("Vieja")
<i>Vuelvo. La encuentro en la puerta, como si nunca se hubiera movido.</i>
*[<i>Le doy el agua.</i>]
// TODO efecto exorcismo, podria ser el flash blanco con otros valores tipo mas lento
~ PlaySound("exorcismo", 0.5)
~ RemoveObject("Vieja")
// TODO Fade to white
// TODO [LA CASA DESAPARECE Y EN SU LUGAR APARECE UN TERRENO]
<i>Apenas la sostiene entre las manos, la casa... desaparece. No se derrumba. No se esfuma. Simplemente deja de estar.</i>

Frente a mí, el terreno. Justo como decía la orden de trabajo.
Mido rápido. El láser funciona. Los números tienen sentido. Pero yo no.
Termino y me voy. No corro, pero camino con ansiedad.
Todavía estoy a tiempo de llegar a casa antes de volver a perderme.
-> END