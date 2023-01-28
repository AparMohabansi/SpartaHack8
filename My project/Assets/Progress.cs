using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    [SerializeField]
    public Image ProgressImage;
    [SerializeField]
    public float start = 0;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        ProgressImage.fillAmount = start;
    }

    // Update is called once per frame
    void Update()
    {
        ProgressImage.fillAmount += GlobalVariables.statusChange;
    }
}