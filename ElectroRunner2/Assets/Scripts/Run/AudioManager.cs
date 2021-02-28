using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource BGM;

    public AudioClip Winm;
    public AudioClip Losem;
    public AudioClip Startm;

    private bool itsgoing;

    void Start()
    {
        itsgoing = false;

        ChangeBGM(Startm);
        itsgoing = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (RunCharacterMovement.isLost == true && itsgoing == false) ChangeBGM(Losem);
        if (RunCharacterMovement.isWon == true && itsgoing == false) ChangeBGM(Winm);
    }

    public void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
        itsgoing = true;
    }
}
