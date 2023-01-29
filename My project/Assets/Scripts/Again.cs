using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Again : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
