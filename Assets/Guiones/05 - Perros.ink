INCLUDE GLOBALS.ink
VAR usedCar = false


->main

===main===
<i>Camino junto al gato. Ya no me apura la meta, ni el reloj.</i>
<i>Siento que cada paso me aleja de la persona que fui esta mañana. Esa persona tan llena de deberes que ya no sabía cómo desear.</i>
<i>Se me cierra el pecho, como si me hubieran recordado algo que había preferido olvidar.</i>
->yahora
=yahora

{ not usedCar:
    // TODO alargar audio, de 10 a 20+ segundos y ver bool para que no se repita
	~ PlaySound("perros", 0.6)
    ¡Perros!
- else:
	<i>Escucho algo allá arriba.</i>
}

    *{clickedCar} [¡Rápido, abajo de ese auto así no me matan!]
        ->BajoAuto
    ->DONE
    *{!clickedCar} [???]
        ->BajoAuto
    ->DONE
    *{clickedTree} [¡Ese árbol! Puedo trepar por ahí.]
        ->ArribaArbol
    ->DONE
    *{!clickedTree} [???]
        ->ArribaArbol
    ->DONE
    * [Me arrinconaron, son ellos o yo...]
        TODO hacer que pueda volver de la death scene
        TODO [IMPLEMENTAR MUERTE]
        ~ PlaySound("PerroMuerte", 0.6)
         ~ textoMuerte = "<i>Duele mucho, hasta que deja de doler...</i>"
        ~ LoadScreenByName("Muerte")
        ->DONE
    +->
    ->yahora
->yahora

===clickCar===
~ clickedCar = true
->main.yahora
->DONE

===clickTree===
~ clickedTree = true
->main.yahora
->DONE

===BajoAuto===
~ usedCar = true
<i>Me oculto lo más rápido que puedo. Parece que se fueron...</i>
* [Mejor sigo viaje antes de que vuelvan]
    ->main.yahora
    ->DONE
* [Hay una alcantarilla. Me meto por ahí.]
    // TODO Va a laberinto
    //[IMPLEMENTAR LABERINTO]
    ~ LoadScreenByName("Muerte")
    ->DONE
->DONE

===ArribaArbol===
    <i>Trepo lo más rápido que puedo y cuando llego arriba ya no escucho nada...</i>
    <i>Me viene una urgencia por mirar desde más arriba.</i>
    <i>Como si, desde una altura, pudiera entender mi lugar en todo esto.</i>
    ~ LoadScreenByName("7 - Tejados")
    ->DONE
->DONE
