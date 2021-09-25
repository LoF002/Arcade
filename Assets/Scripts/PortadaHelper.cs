using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortadaHelper : MonoBehaviour
{
    public string EscenaJuego, EscenaPuntaje;
    public void IniciarJuego()
    {
        try
        {
            GameManager.instancia.CambiarEscena(EscenaJuego);
        }//Fin try
        catch (System.Exception ex)
        {
            Debug.Log("No hay GameManager en la escena "+ex);
        }//Fin catch
    }//Fin metodo

    public void VerMejoresPuntajes()
    {
        try
        {
            GameManager.instancia.CambiarEscena(EscenaPuntaje);
        }//Fin try
        catch (System.Exception ex)
        {
            Debug.Log("No hay GameManager en la escena " + ex);
        }//Fin catch
    }//Fin metodo

    public void Salir()
    {

    }//Fin metodo

}
