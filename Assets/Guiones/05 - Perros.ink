INCLUDE GLOBALS.ink
VAR usedCar = false
VAR dogsStarted = false

->main

===main===
<i>Camino junto al gato. Ya no me apura la meta, ni el reloj.</i>
<i>Siento que cada paso me aleja de la persona que fui esta mañana. Esa persona tan llena de deberes que ya no sabía cómo desear.</i>
<i>Se me cierra el pecho, como si me hubieran recordado algo que había preferido olvidar.</i>
->yahora
=yahora

{ not usedCar:
    // TODO alargar audio, de 10 a 20+ segundos y ver bool para que no se repita
	{not dogsStarted: 
	    ~ PlaySound("perros", 0.6)
	    ~ DeathTimer(15)
	    ~ dogsStarted = true
	}
    ¡Perros!
- else:
	<i>Escucho algo allá arriba.</i>
}

    *{clickedCar} [¡Rápido, abajo de ese auto así no me matan!]
        ~StopDeathTimer()
        ->BajoAuto
    ->DONE
    *{!clickedCar} [???]
        ->BajoAuto
    ->DONE
    *{clickedTree} [¡Ese árbol! Puedo trepar por ahí.]
        ~StopDeathTimer()
        ->ArribaArbol
    ->DONE
    *{!clickedTree} [???]
        ->ArribaArbol
    ->DONE
    *{!usedCar}[Me arrinconaron, son ellos o yo...]
        ~ StopDeathTimer()
        ~ PlaySound("PerroMuerte", 0.6)
        ~ textoMuerte = "<i>Duele mucho, hasta que deja de doler...</i>"
        ~ LoadScreenByName("Muerte")
        ->DONE
    *{usedCar}[Puedo ir por la alcantarilla bajo el auto]
        ->BajoAuto.alcantarillaStitch
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
    ->alcantarillaStitch
    =alcantarillaStitch
    ~ FadeInObject("BlackPlane", 1)
    <i>Las paredes de la alcantarilla están tibias, como si guardaran memoria. No huele mal.</i>
    <i>Huele a encierro viejo. A secreto mal guardado.</i>
    ~ LoadObject("aqui")
    ~ FadeOutObject("BlackPlane", 2)
    <i>Cuando salgo al otro lado, no reconozco nada. Y al mismo tiempo, todo me resulta conocido.</i>
    <i>El cartel no me dice adónde ir. Solo me recuerda que existo.</i>
    <i>Hasta que lo veo.</i>
    ~ LoadScreenByName("3.4 - Brujula")
    ->DONE
->DONE

===ArribaArbol===
    <i>Trepo lo más rápido que puedo y cuando llego arriba ya no escucho nada...</i>
    <i>Me viene una urgencia por mirar desde más arriba.</i>
    <i>Como si, desde una altura, pudiera entender mi lugar en todo esto.</i>
    ~ LoadScreenByName("7 - Tejados")
    ->DONE
->DONE
