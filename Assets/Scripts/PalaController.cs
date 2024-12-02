using UnityEngine;

public class PalaController : MonoBehaviour
{
    const float MAX_Y = 4.2f;
    const float MIN_Y = -4.2f;

    // velocidad de la pala
    [SerializeField] float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.CompareTag("PalaPlayer1"))
        {
            // Control de la pala del jugador 1
            ControlPalaJugador1();
        }
        else if (gameObject.CompareTag("PalaPlayer2"))
        {
            // Control de la pala del jugador 2
            ControlPalaJugador2();
        }

    }

    void ControlPalaJugador1()
    {
        if (Input.GetKey("up") && transform.position.y < MAX_Y)
        {
            // Mover la pala hacia arriba
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("down") && transform.position.y > MIN_Y)
        {
            // Mover la pala hacia abajo
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    void ControlPalaJugador2()
    {
        if (Input.GetKey("w") && transform.position.y < MAX_Y)
        {
            // Mover la pala hacia arriba
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("s") && transform.position.y > MIN_Y)
        {
            // Mover la pala hacia abajo
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
