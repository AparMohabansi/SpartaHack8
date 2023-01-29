using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap_Neg : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
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
    public GameObject other11;
    public GameObject other12;
    public GameObject other13;
    public GameObject other14;
    public GameObject other15;
    public GameObject other16;
    public GameObject other17;
    public GameObject other18;
    public GameObject other19;
    public GameObject other20;
    public GameObject other21;
    public GameObject other22;
    public GameObject other23;
    public GameObject other24;

    public void SwapPanel()
    {
        if (Panel1 != null)
        {
            Panel1.SetActive(false);
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
            other11.SetActive(false);
            other12.SetActive(false);
            other13.SetActive(false);
            other14.SetActive(false);
            other15.SetActive(false);
            other16.SetActive(false);
            other17.SetActive(false);
            other18.SetActive(false);
            other19.SetActive(false);
            other20.SetActive(false);
            other21.SetActive(false);
            other22.SetActive(false);
            other23.SetActive(false);
            other24.SetActive(false);
        }

        if (Panel2 != null)
        {
            Panel2.SetActive(true);
        }
    }
}
