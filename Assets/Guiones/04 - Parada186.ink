INCLUDE GLOBALS.ink
VAR gato_text_color = "purple"

->main

===main===
¿Por qué me mira así este gato?
    ->stitch
    =stitch
    * ¿Tenés idea dónde está la fuente?
        ->AcertijoGato
    * Volver a la casa vieja
        ~ LoadScreen(3)
->DONE

=== AcertijoGato ===
    <color={gato_text_color}>Claro que lo sé. Pero...</color>
    <color={gato_text_color}>Si en un cuarto hay varios gatos, cada gato en un rincón, cada uno ve 3 gatos, ¿Sabés cuántos gatos son?</color>
    * 4
        <color={gato_text_color}>Claro que somos 4, doblá a la derecha y en 2 cuadras llegás a la fuente. Saludá a los demás si los ves.</color>
        TODO No me salió apagar al gato
        //~ RemoveObject("TuxedoCat") 
         ->4Gatos
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
        TODO No me salió apagar al gato
        //~ RemoveObject("TuxedoCat") 
        ->main.stitch
->DONE

=== 4Gatos ===
    * OK, voy para la derecha entonces
        ~ LoadScreen(5)
        ->DONE
    * Este gato me dijo que vaya a la derecha, pero él se fué a la izquierda, mejor lo sigo
        TODO Camino del pasado
        [VA A ESCENA NUEVA: PASADO]
        //->DONE
        // temporalmente dejo esto para poder elegir la otra opcion
        ->4Gatos
    * Mirá si le voy a hacer caso a un gato parlante, yo me vuelvo por donde vine
        ~ LoadScreen(3)
->DONE