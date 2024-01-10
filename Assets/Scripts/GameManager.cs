using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Slider sliderSound;
    [SerializeField] Slider sliderMusic;

    [SerializeField] AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        audioClip = GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
