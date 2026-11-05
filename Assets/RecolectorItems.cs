
using UnityEngine;

public class RecolectorItems : MonoBehaviour
{
    private int puntajeTotal = 0;

    // Este código se ejecuta cuando el águila (jugador) toca una gema o cereza
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. Buscamos si el nombre del objeto que tocamos contiene la palabra "gem" (gema/diamante)
        if (collision.gameObject.name.ToLower().Contains("gem"))
        {
            puntajeTotal += 10;
            Debug.Log("¡Gema recolectada! +10 puntos. Puntaje total: " + puntajeTotal);

            // Destruye la gema de la pantalla
            Destroy(collision.gameObject);
        }
        // 2. Si no es gema, buscamos si el nombre contiene la palabra "cherry" (cereza)
        else if (collision.gameObject.name.ToLower().Contains("cherry"))
        {
            puntajeTotal -= 5;
            Debug.Log("¡Cereza comida! -5 puntos. Puntaje total: " + puntajeTotal);

            // Destruye la cereza de la pantalla
            Destroy(collision.gameObject);
        }
    }
}