INCLUDE GLOBALS.ink

->main

===main===
TODO SFX de alas de pajaro
[Persigue una urraca por los tejados]
¡Se fué por ahí!
    *¡Allá está <color=yellow>la fuente</color>! Voló cerca del agua y dejo caer algo en la fuente
        ~ LoadScreen(8)
        ->DONE
    * No parece muy alto, si me tiro a esa rama llego más rápido
        TODO hacer que pueda volver de la death scene
        [IMPLEMENTAR MUERTE]
        ~ LoadScreen(9)
        ->DONE
->DONE