EXTERNAL LoadScreen(int screenNumber)
  INCLUDE GLOBALS.ink
  
->main

===main===
 * Ya fue, me vuelvo a casa.
    ~ LoadScreen(4)
    ->DONE
 * Si camino para la derecha salgo a Triunvirato. Quizás alguien me pueda guiar.
     ->TBD
*{infoViejoFuente}Dicen que las calles paralelas a La Pampa convergen en <color=yellow>la fuente</color>. Mejor camino para allá.
    ~ LoadScreen(4)
->DONE



=== TBD ===
Prueba del gato
    *{tuxedoCatMansion}Encontraste al <color=yellow>tuxedo Cat</color>. Seguirlo.
    ~ LoadScreen(4)
    ->DONE
    *Opcion generica
    ->main
