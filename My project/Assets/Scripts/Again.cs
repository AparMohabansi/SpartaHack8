using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Again : MonoBehaviour
{
    public void PlayAgain()
    {
        GlobalVariables.statusChange = 0;
        GlobalVariables.policyChange = 0;
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
