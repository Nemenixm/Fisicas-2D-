using UnityEngine;

public class SwordDetection2D : MonoBehaviour
{
    [SerializeField] private float forceBase=100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Preguntar si un objeto tiene puesto un componente. Siempre que queramos hacer algo sobre objetos determinados.
        if (collision.GetComponent<Rigidbody2D>() != null)
        {
            Vector2 forceDirection=collision.transform.position - transform.position;//Objeto position - espada position
            float Distance=(2 - Vector2.Distance(collision.transform.position, transform.position));
            collision.GetComponent<Rigidbody2D>().AddForce(forceDirection * Distance * forceBase);
        }
    }
}
