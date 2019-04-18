using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTSound : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // ショット音を鳴らす
        //GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playSound()
    {

        // ショット音を鳴らす
        GetComponent<AudioSource>().Play();
    }
    public void playBGM()
    {

        // ショット音を鳴らす
        GetComponent<AudioSource>().Play();
    }
}
