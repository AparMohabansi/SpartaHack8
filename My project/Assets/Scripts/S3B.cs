using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S3B : MonoBehaviour
{

    
    public Button self;

    //This is the buying program
    [SerializeField]
    public float status = 0;

    [SerializeField]
    public float policy = 0;

    public void Purchase()
    {
        GlobalVariables.statusChange += status;
        GlobalVariables.policyChange += policy;

        
        self.interactable = false;
    }
}
