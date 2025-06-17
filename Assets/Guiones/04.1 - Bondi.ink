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
* [Apoyo la cabeza contra la ventana...]
    ~ FadeInObject("BlackPlane", 3)
    ~ SetBGMVolume(0.01)
    <i>Me duermo... El zumbido del motor desaparece...</i>
    <i>El silencio me empuja hacia adentro, como si el colectivo dejara de moverse pero yo siguiera cayendo.</i>
    // TODO APARECE UNA FIGURA ROJA A LO LEJOS
    <color={devil_text_color}>No te preocupes, no te vas a perder.</color>
    <i>Una figura roja se acerca, me mira y sonríe.</i>
    <color={devil_text_color}>No te vas a perder, porque no vas a volver a despertar.</color>
    <i>Solo veo oscuridad. Esa figura me llama. No quiero ir... </i>
    <i>Pero quizás es la única que me queda.</i>
    //TODO LA FIGURA ROJA SE ACERCA AÚN MAS Y AHORA LA VEMOS EN PPP
    // TODO DIABLO - LOCUCIÓN
    ~ PlaySound("devilSpeak", 1)
    <color={devil_text_color}>Nadie se pierde en Parque Chas. Solo dejan de buscar la salida.</color>
    ~ textoMuerte = "Vas con la figura, ya no buscás tu destino ni tu salida..."
    ~ LoadScreenByName("Muerte")
    ->DONE
->DONE
