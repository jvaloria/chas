INCLUDE GLOBALS.ink

->main

===main===
<i>Un mural...</i>
<i>Viejo, descascarado, pero vivo. Como esas cosas que el tiempo no destruye porque nadie se atreve a olvidarlas.</i>
<i>Es un mapa del barrio. Siento que no es un mapa para salir.</i>
->stitch
=stitch
<i>Es un mapa del barrio. Siento que no es un mapa para salir.</i>
->stitch
->DONE

===triggerBrujula===
<i>En el centro, una <color="yellow">brújula</color> gira sin parar.</i>
* [Esta brújula, la necesito...]
    // final malo
    <i>En ese instante, todo se repliega. Como si el mundo diera un suspiro y me soltara.</i>
    <i>Ya no busco Ávalos ni Cádiz. Ya no busco salir.</i>
    <i>Parque Chas me guarda... Y yo lo dejo.</i>
    ~ textoMuerte = "Mi alma se pierde para siempre en Parque Chas"
    ~ LoadScreenByName("Muerte")
    ->DONE
* [No confío en esta brújula, no todo lo que guía lleva a donde uno quiere estar.]
    ~ RemoveObject("Brujula")
    ~ LoadObject("CalicoCat")
    // TODO trigger miau effect
    <i>El gato me mira tranquilo, como si supiera que voy a seguirlo.</i>
    <i>Y lo sigo.</i>
    ~ LoadScreenByName("3.5 - Transicion Fuente") 
    ->DONE
->DONE

