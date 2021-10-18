using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    // Start is called before the first frame update
    public string mensaje;

    public GameObject cubito;

    void OnMessageArrived(string msg)
    {
        Debug.Log(msg);
        int valor = int.Parse(msg);
        if(valor < 337)
        {
            cubito.transform.Rotate(100, 0, 0);
        }
        else if (valor < 674)
        {
            
        }
        else
        {
            cubito.transform.Rotate(-100, 0, 0);
        }
    }

    void OnConnectionEvent(bool success)
    {

    }
}
