INCLUDE GLOBALS.ink
VAR devil_text_color = "\#FF9E9E"
VAR cat_text_color = "\#FF400E"
//~ siameseCatMansion = true

->main

===main===
<i>Que raro este bondi, la máquina no anda.</i>
<color={devil_text_color}>Pasa... en el fondo siempre hay lugar.</color>
<i>Me siento e inmediatamente me pesan los parpados</i>
*{siameseCatMansion} [¿Un gato en el bondi? Me habrá seguido arriba]
    ~ LoadObject("DevilCatBig")
    <i>El gato siamés se sienta a mi lado, me mira y ronronea.</i>
    <color={cat_text_color}>El tiempo pasa distinto acá... bajate... tenés mucho por qué vivir.</color>
    ~ LoadScreenByName("Final 2 - Baja del bondi")
    ->DONE
*{!siameseCatMansion} [???]
    ->DONE
* [Siento que me hundo...]
        TODO hacer que pueda volver de la death scene
        TODO [IMPLEMENTAR MUERTE]
    ~ LoadScreenByName("Muerte")
    ->DONE
->DONE