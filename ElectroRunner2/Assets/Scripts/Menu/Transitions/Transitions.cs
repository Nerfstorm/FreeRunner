using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transitions : MonoBehaviour
{
    public static int scena;

    public Sprite[] images;
    
    public Image yes;

    void Start()
    {
        int num = UnityEngine.Random.Range(0, 9);
        yes.sprite = images[num];
    }
}
