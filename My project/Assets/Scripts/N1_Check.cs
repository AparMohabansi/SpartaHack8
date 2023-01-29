using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class N1_Check : MonoBehaviour
{
    public Button unlock;
    public Button check1;
    public Button check2;
    public Button check3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((check1.interactable == false) && (check2.interactable == false) && (check3.interactable == false))
        {
            unlock.interactable = true;
        }
    }
}
