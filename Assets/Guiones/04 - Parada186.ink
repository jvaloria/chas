INCLUDE GLOBALS.ink
VAR gato_text_color = "purple"

->main

===main===
    ->stitch
    =stitch
    <i>Doblo la esquina y el aire cambia. Otra vez el gato, me mira fijo.</i>
    <i>Es como si el animal tuviera una lengua que no suena pero se entiende.</i>

    <color={gato_text_color}>Te estabas por olvidar de vos, ¿no?</color>

    <i>No me asusto. No me río. Acepto. Porque algo en mí sabe que es cierto.</i>
    <i>Y que esta conversación inexplicable es profundamente real.</i>

    * ¿Sabés dónde queda <color=yellow>la fuente</color>?
        ->AcertijoGato
        ~ LoadScreen(6)
    * [No tengo tiempo para maullidos filosóficos. Vuelvo a la casa, mido y me voy.]
        ~ LoadScreen(4)
->DONE

=== AcertijoGato ===
    <color={gato_text_color}>Claro que lo sé. Pero...</color>
    <color={gato_text_color}>Si en un cuarto hay varios gatos, cada gato en un rincón, cada uno ve 3 gatos, ¿Sabés cuántos gatos son?</color>
    * 4
        <color={gato_text_color}>Claro que somos 4</color>
        <i>El gato se aleja como si supiera a dónde va… y yo lo sigo.</i>
        ~ RemoveObject("TuxedoCat")
        ~ LoadScreen(6)
         //->4Gatos
    * 186
        TODO SFX de Gato maullido enojado y se vá
        TODO Aparece el bondi 186 y te lleva por el camino del diablo
        [VA A ESCENA NUEVA: DIABLO]
        //~ LoadScreen(5)
        //->DONE
        // temporalmente dejo esto para poder elegir la otra opcion
        ->main.stitch
    * ¿Qué?!!
        Miauu
        ~ RemoveObject("TuxedoCat")
        ->main.stitch
->DONE

=== 4Gatos ===
    * [OK, voy para la derecha entonces]
        ~ LoadScreen(6)
        ->DONE
    * [El gato dijo derecha, pero se fué a la izquierda, mejor lo sigo]
        TODO Camino del pasado
        [VA A ESCENA NUEVA: PASADO]
        //->DONE
        // temporalmente dejo esto para poder elegir la otra opcion
        ->4Gatos
    * [Mirá si le voy a hacer caso a un gato parlante, vuelvo por donde vine]
        ~ LoadScreen(4)
->DONE