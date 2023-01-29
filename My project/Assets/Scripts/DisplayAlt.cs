using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAlt : MonoBehaviour
{
    public GameObject Text;
    public GameObject Buy;
    public GameObject other1;
    public GameObject other2;
    public GameObject other3;
    public GameObject other4;
    public GameObject other5;
    public GameObject other6;
    public GameObject other7;
    public GameObject other8;
    public GameObject other9;
    public GameObject other10;

    public void Activate()
    {
        if (Text != null)
        {
            Text.SetActive(true);
            Buy.SetActive(true);

            other1.SetActive(false);
            other2.SetActive(false);
            other3.SetActive(false);
            other4.SetActive(false);
            other5.SetActive(false);
            other6.SetActive(false);
            other7.SetActive(false);
            other8.SetActive(false);
            other9.SetActive(false);
            other10.SetActive(false);
        }
    }
}
