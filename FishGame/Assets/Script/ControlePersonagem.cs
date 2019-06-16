    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{

    [SerializeField] float turnSpeed = 100;
    [SerializeField] float pullSpeed = 10;
    [SerializeField] float pushSpeed = 10;
    [SerializeField] GameObject anzol;
    [SerializeField] Transform target;
    [SerializeField] float thrustAnzol = 150;
    [SerializeField] float thrust = 150;
    [SerializeField] Rigidbody rbAnzol;
    

   // [SerializeField] Rigidbody rb;

    float speed = 100f;

    bool launched = false;


    void Start()
    {

        rbAnzol = anzol.GetComponent<Rigidbody>();
     //   rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.Space))
        {

            ////isso tem q ser no start
            print("Lanca o anzol");
            launched = true;
            Debug.Log("foi lauched");
        }


    }

    // Update is called once per frame
    void Update()
    {
      //  if ((Input.GetKey(KeyCode.Space)) && !launched)
      //  {

            /// A principio teriamos um lançamento do anzol na agua porem não estou conseguindo
            /// 

          //  rbAnzol.AddForce(transform.forward * 100, ForceMode.Acceleration);
          //  rbAnzol.AddForce(transform.up * 100, ForceMode.Acceleration);
            ////isso deveria ser a catapulta
      //      print("Lanca o anzol");
            
      //      launched = true;
       //     Debug.Log("foi lauched");
            
      //  }
        if ((Input.GetKey(KeyCode.A))&& (transform.rotation.y <= 160))
        {
            
   
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            rbAnzol.AddForce(transform.right * thrust);
        }
        if ((Input.GetKey(KeyCode.D))&& (transform.rotation.y >= 0))
        {
            transform.Rotate(Vector3.down, turnSpeed * Time.deltaTime);
            rbAnzol.AddForce(transform.right * -thrust);
    
        }
    //    if (launched)
     //   {
            if (Input.GetKey(KeyCode.Space))
            {
                float step = speed * Time.deltaTime;
                anzol.transform.position = Vector3.MoveTowards(anzol.transform.position, target.position, step);
                print("Puxa o anzol");

            }
       // }
    }
}
