INCLUDE GLOBALS.ink
VAR gato_text_color = "purple"

->main

===main===
    {tuxedoCatMansion:
        ~ LoadObject("TuxedoCat")
    }
    <i>Doblo la esquina y el aire cambia. {tuxedoCatMansion: Otra vez el gato, me mira fijo.}</i>
    ->stitch
    =stitch
    <i>Otra encrucijada.</i>
    * [<i>Mejor vuelvo a buscar el terreno, mido y me voy.</i>]
        ~ LoadScreenByName("3 - Casa Embrujada")
        ->DONE
    ->stitch
->DONE

=== ParadaBondi ===
<i>¡Un colectivo!</i> {TimedOption(0, 8)}
*[<i>Me lo tomo, cualquier lugar es mejor que acá.</i>]
~ LoadScreenByName("4.1 - Bondi")
->DONE
* [<i>Mejor vuelvo a buscar el terreno, mido y me voy.</i>]
        ~ LoadScreenByName("3 - Casa Embrujada")
        ->DONE
->DONE


===gatoTalk===
    ~ LoadObject("PanelBloqueante")
    <i>Es como si el animal tuviera una lengua que no suena pero se entiende.</i>

    <color={gato_text_color}>Te estabas por olvidar de vos, ¿no?</color>

    <i>No me asusto. No me río. Acepto. Porque algo en mí sabe que es cierto.</i>
    <i>Y que esta conversación inexplicable es profundamente real.</i>

    * ¿Sabés dónde queda <color=yellow>la fuente</color>?
        ->AcertijoGato
        ~ LoadScreenByName("5 - Perros")
    + [No tengo tiempo para maullidos filosóficos.]
        ~ RemoveObject("PanelBloqueante")
        ~ RemoveObject("TuxedoCatBig")
        ~ LoadObject("TuxedoCat")
        ->main.stitch
->DONE

=== AcertijoGato ===
    <color={gato_text_color}>Claro que lo sé. Pero...</color>
    <color={gato_text_color}>Si en un cuarto hay varios gatos, cada gato en un rincón, cada uno ve 3 gatos, ¿Sabés cuántos gatos son?</color>
    * 4
        <color={gato_text_color}>Claro que somos 4</color>
        <i>El gato se aleja como si supiera a dónde va… y yo lo sigo.</i>
        ~ RemoveObject("TuxedoCatBig")
        ~ LoadScreenByName("5 - Perros")
        ->DONE
    * ¿Qué?!!
        // TODO SFX de Gato maullido enojado y se vá
        Miauu
        ~ RemoveObject("TuxedoCatBig")
        ~ RemoveObject("PanelBloqueante")
        ->main.stitch
->DONE
