using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaitController : MonoBehaviour
{
    public static bool pescou = false;
    public static bool pegouUm = false;
    public GameObject peixePescado;
    [SerializeField] GameObject peixeNoAnzol;
    [SerializeField] GameObject anzolPos;

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
            ///
            Destroy(peixePescado.gameObject);
            Debug.Log("pescou");
            peixeNoAnzol.SetActive(true);
            
           
        }
        if (pegouUm)
        {
            peixeNoAnzol.SetActive(false);

            //// FAZ A PONTUAÇÃO AQUI!!!!!!!!!!!!!!!!!!!!!!!!
            //////
            ////
            ///
            /// faz animaçao do pescador lançando ... depois da animacao entra esse transform
            /// 

            this.transform.position = anzolPos.transform.position;
            pegouUm = false;
            pescou = false;



        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("foi");
        if ((collision.gameObject.tag == "Fish")&& (!pescou)) /// anzol pega peixe na colisao
        {
         
            pescou = true;
            peixePescado = collision.gameObject;

           
        }
        else if(collision.gameObject.tag == "Fisher")
        {
            pescou = false;
            Debug.Log("PEGUEI UM!!!");
            pegouUm = true;

        }
        else if (collision.gameObject.tag == "SHARK")
        {
            /////// FAZ O GAME OVER AQUI!!!!!!!!!!!!!!!!
            Debug.Log("GAMEOVER");
        }

    }


    

}
