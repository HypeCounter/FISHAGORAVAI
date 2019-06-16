using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaitController : MonoBehaviour
{
    public static bool pescou = false;
    public GameObject peixePescado;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (pescou)
        {
            // peixePescado.transform.position = this.transform.position;
            // eu ia fazer o peixe acompanhar o anzol ate o pescador mas parece que o peixe sai voando pelo mapa... como nao tenho tempo e não tenho ajuda do grupo que não sabe programa e sim ver gameplay no youtube vou fazer da forma mais idiota possivel

            Destroy(peixePescado.gameObject);
            Debug.Log("pescou");

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("foi");
        if (collision.gameObject.tag == "Fish")
        {
         
            pescou = true;
            peixePescado = collision.gameObject;

           
        }
        else if(collision.gameObject.tag == "Fisher")
        {
            pescou = false;
            Debug.Log("PEGUEI UM!!!");
            

        }

    }


    

}
