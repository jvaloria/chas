INCLUDE GLOBALS.ink
VAR calicoCat = false
->main

===main===
<i>Este gato me observa con esa mezcla de indiferencia y complicidad que solo los gatos manejan.</i> 
<i>Me mira como si ya supiera que lo voy a seguir. Me invita a perderme.</i>
->yahora
=yahora
<i>Si lo sigo... Ya no estaré buscando calles, sino otra cosa.</i>
*{calicoCat} [Sigo al gato. Algo en mí ya está rendido.]
    ~ LoadScreenByName("Brujula")
    ->DONE
*{!calicoCat} [???]
    ->DONE

*[No. Doy media vuelta y busco otra salida. Tengo que salir de este barrio.]
//(ESTO TE LLEVA AL CAMINO DEL GATO SIAMES)
~ LoadScreenByName("4 - Parada186")
->DONE


===calicoCatClicked===
~ calicoCat = true
¡Ey, esperá!
->main.yahora