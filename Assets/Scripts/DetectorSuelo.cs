using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorSuelo : MonoBehaviour
{
    public static bool detectorsuelo;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        detectorsuelo = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        detectorsuelo = false;

    }
}
