using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sw2 : MonoBehaviour
{
    public Button Animation; 
    public string SampleScene; 

    void Start()
    {
        Animation.onClick.AddListener(Switch);
    }

    void Switch()
    {
        SceneManager.LoadScene(SampleScene);
    }


}
