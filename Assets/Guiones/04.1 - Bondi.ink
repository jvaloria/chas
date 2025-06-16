INCLUDE GLOBALS.ink
VAR devil_text_color = "\#FF9E9E"
VAR devilCat_text_color = "\#FF400E"
//~ devilCatMansion = true

->main

===main===
<i>Que raro este bondi, la máquina no anda.</i>
<color={devil_text_color}>Pasa... en el fondo siempre hay lugar.</color>
<i>Me siento e inmediatamente me pesan los parpados</i>
*{devilCatMansion} [¿Un gato en el bondi? Me habrá seguido arriba]
    ~ LoadObject("DevilCatBig")
    <i>El gato siamés se sienta a mi lado, me mira y ronronea.</i>
    <color={devilCat_text_color}>El tiempo pasa distinto acá... bajate... tenés mucho por qué vivir.</color>
    ~ LoadScreenByName("Final 2 - Baja del bondi")
    ->DONE
*{!devilCatMansion} [???]
    ->DONE
* [Siento que me hundo...]
        TODO hacer que pueda volver de la death scene
        TODO [IMPLEMENTAR MUERTE]
    ~ LoadScreenByName("Muerte")
    ->DONE
->DONE