using UnityEngine;

public class MovimientoAguila : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    public float velocidad = 5f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Conseguimos los componentes del objeto automáticamente
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Detecta las flechas del teclado o las teclas WASD
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        float movimientoVertical = Input.GetAxisRaw("Vertical");

        // Calcula el vector de dirección corregido
        Vector2 direccion = new Vector2(movimientoHorizontal, movimientoVertical).normalized;

        // Mueve al personaje usando el Rigidbody2D (es lo correcto al usar física)
        rb.velocity = direccion * velocidad;

        // Voltea el sprite automáticamente hacia donde camina
        if (movimientoHorizontal > 0)
        {
            spriteRenderer.flipX = false; // Mira a la derecha
        }
        else if (movimientoHorizontal < 0)
        {
            spriteRenderer.flipX = true; // Mira a la izquierda
        }
   

    // Aquí termina el movimiento de las flechas
    rb.velocity = direccion* velocidad;
} // <- Esta llave cierra las flechas (línea 39)

    // ENSEGUIDA (línea 40), pones el código de la gema:
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gema"))
        {
            Destroy(other.gameObject);
            Debug.Log("¡Gema recogida!");
        }
    }
} // <- Esta última llave cierra todo el archivo


