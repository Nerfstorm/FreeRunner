using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;


public class Bar : MonoBehaviour
{
    public GameObject bar;
    public int time;

    int scenai;

    void Start()
    {
        scenai = Transitions.scena;

        AnimateBar();
        Invoke("Loading", time);
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar, 1, time);
    }

    void Loading()
    {
        SceneManager.LoadScene(scenai);
    }
}
