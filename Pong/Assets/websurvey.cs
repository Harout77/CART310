using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class websurvey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void survey()
    {

        Application.OpenURL("https://docs.google.com/forms/d/1ASOIyyX_zT4u3E3HIyKQTMTh0EV7xmIVwsaEkzWoXSE/prefill");

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
