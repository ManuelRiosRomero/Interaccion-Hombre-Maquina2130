using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar : MonoBehaviour
{
    public bool esta;
    public bool laOtra;
    public GameObject cubito;

    public void DetectoEsta()
    {
        esta = true;
    }
    public void perdioEsta()
    {
        esta = false;
    }
    public void DetectoOtra()
    {
        laOtra = true;
    }
    public void perdioOtra()
    {
        laOtra = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        esta = false;
        laOtra = false;
    }

    // Update is called once per frame
    void Update()
    {
        if( esta && laOtra)
        {
            cubito.SetActive(true);
        }
        else
        {
            cubito.SetActive(false);
        }
    }
}
