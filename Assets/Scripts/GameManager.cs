using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Slider sliderSound;
    [SerializeField] Slider sliderMusic;

    [SerializeField] AudioClip audioClip;


    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }    
   
    void Start()
    {
        audioClip = GetComponent<AudioClip>();
    }

    void Update()
    {
        
    }
}
