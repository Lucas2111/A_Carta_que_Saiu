using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acartaquesaiu : MonoBehaviour
{
    int nipe;
    int numero;

    string txtnipe;

    // Update is called once per frame
    void Update()
    {
        
        nipe = Random.Range(1, 5);
        numero = Random.Range(1,14);

        if (nipe == 1) txtnipe = "espadas";

        else if (nipe == 2) txtnipe = "copas";
        else if (nipe == 3) txtnipe = "ouro";
        else if (nipe == 4) txtnipe = "paus";

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (numero == 1)
                Debug.Log("ás de " + txtnipe);

            else if (numero == 11)
                Debug.Log("valete de " + txtnipe);

            else if (numero == 12)
                Debug.Log("dama de " + txtnipe);

            else if (numero == 13)
                Debug.Log("rei de " + txtnipe);

            else
                Debug.Log(numero + " de " + txtnipe );












        }
    }
}
