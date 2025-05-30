EXTERNAL LoadScreen(int screenNumber)
  INCLUDE GLOBALS.ink
  
->main

===main===
 * Ya fue, me vuelvo a casa.
    ~ LoadScreen(4)
 * Si camino para la derecha salgo a Triunvirato. Quizás alguien me pueda guiar.
     ->TBD
*{infoViejoFuente}Dicen que las calles paralelas a La Pampa convergen en <color=yellow>la fuente</color>. Mejor camino para allá.
    ~ LoadScreen(4)
->DONE

=== TBD ===
TODO: Implementar cambio de BG/scene
->DONE
