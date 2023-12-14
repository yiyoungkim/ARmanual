using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sw : MonoBehaviour
{
    public Button Animation; 
    public string ARf; 

    void Start()
    {
        Animation.onClick.AddListener(Switch);
    }

    void Switch()
    {
        SceneManager.LoadScene(ARf);
    }


}