using UnityEngine;

public class Trigger2DDetection : MonoBehaviour
{
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
        // if (collision.gameObject.layer ==7)//Player entra en la zona (El 7 es el numero de la layer PLAYER)
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            GetComponent<Animator>().SetBool("IsOpened", true);

        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
