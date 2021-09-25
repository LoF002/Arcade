using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 posInicial;

    // Start is called before the first frame update
    void Start()
    {
        posInicial = 
            new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z
            );
    }//Fin Star

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter ha sido presionado");

            transform.position = new Vector3(posInicial.x, posInicial.y, posInicial.z);

            this.GetComponent<Rigidbody>().velocity = Vector3.zero;

        }//Fin if
    }//Fin update

    public void Alerta()
    {
        Debug.Log("Conexion con trigger ready");
    }

}
