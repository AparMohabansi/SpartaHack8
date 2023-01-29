using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOrLose : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if ((double) GlobalVariables.policyChange <= 0)
        {
            SceneManager.LoadScene(sceneBuildIndex: 2);
        }
        if ((double) GlobalVariables.statusChange >= 1)
        {
            SceneManager.LoadScene(sceneBuildIndex: 3);
        }
    }
}
