using UnityEngine;

public class PelotaController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float force;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(1, 1) * force, ForceMode2D.Impulse);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
