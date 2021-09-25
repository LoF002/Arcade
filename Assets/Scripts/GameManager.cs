using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instancia;

    public static GameManager instancia
    {
        get
        {
            return _instancia;
        }//Fin get
    }//Fin 

    public void Awake()
    {
        if (_instancia == null)
        {
            _instancia = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }//Fin awake

    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
