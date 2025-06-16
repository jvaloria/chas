INCLUDE GLOBALS.ink
VAR devil_text_color = "\#FF9E9E"

->main

===main===
<i>Que raro este bondi, la máquina no anda.</i>
<color={devil_text_color}>Pasa... en el fondo siempre hay lugar.</color>
<i>Me siento e inmediatamente me pesan los parpados</i>
*{siameseCatMansion} [¿Un gato en el bondi? Me habrá seguido arriba]
    ~ LoadScreenByName("Final 2 - Baja del bondi")
    ->DONE
*{!siameseCatMansion} [???]
    ~ LoadScreenByName("Final 2 - Baja del bondi")
    ->DONE
* [Siento que me hundo...]
        TODO hacer que pueda volver de la death scene
        TODO [IMPLEMENTAR MUERTE]
    ~ LoadScreenByName("Muerte")
    ->DONE
->DONE