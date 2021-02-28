using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMenu : MonoBehaviour
{

    public bool CameraMove = true;

    public GameObject referinta; //pozitia canvasului
    public GameObject RectMenuPanel;

    public GameObject RectQuestPanel1;
    public GameObject RectQuestPanel2;
    public GameObject RectQuestPanel3;
    public GameObject RectQuestPanel4;
    public GameObject RectQuestPanel5;
    public GameObject RectQuestPanel6;

    public float time = 0.5f;
    private float time2 = 0.6f;

    bool  Open1 = false;
    float position;
    int yes;

    void Start()
    {
        Time.timeScale = 1;
        Open1 = false;
    }

    private void Update()
    {
        position = referinta.transform.position.x;
    }


    public void MenuPanel()
    {
        if (Open1 == false)
        {
            CameraMove = false;
            LeanTween.moveX(RectMenuPanel, position-250f, time);
            Open1 = true;
            Invoke("Creier", time2);
        }
        else
        {
            CameraMove = false;
            LeanTween.moveX(RectMenuPanel, position-335f, time);
            Open1 = false;
            Invoke("Creier", time2);
        }
    }

    //-----------------------------------------------------------------------

    public void QuestPanel1()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel1, position + 180f, time);
        Invoke("Creier", time2);
    }

    public void CloseQuestPanel1()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel1, position + 290f, time);
        Invoke("Creier", time2);
    }

    //-----------------------------------------------------------------------

    public void QuestPanel2()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel2, position + 180f, time);
        Invoke("Creier", time2);
    }

    public void CloseQuestPanel2()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel2, position + 290f, time);
        Invoke("Creier", time2);
    }

    //-----------------------------------------------------------------------

    public void QuestPanel3()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel3, position + 180f, time);
        Invoke("Creier", time2);
    }

    public void CloseQuestPanel3()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel3, position + 290f, time);
        Invoke("Creier", time2);
    }

    //-----------------------------------------------------------------------

    public void QuestPanel4()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel4, position + 180f, time);
        Invoke("Creier", time2);
    }

    public void CloseQuestPanel4()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel4, position + 290f, time);
        Invoke("Creier", time2);
    }

    //-----------------------------------------------------------------------

    public void QuestPanel5()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel5, position + 180f, time);
        Invoke("Creier", time2);
    }

    public void CloseQuestPanel5()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel5, position + 290f, time);
        Invoke("Creier", time2);
    }

    //-----------------------------------------------------------------------
    public void QuestPanel6()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel6, position + 180f, time);
        Invoke("Creier", time2);
    }

    public void CloseQuestPanel6()
    {
        CameraMove = false;
        LeanTween.moveX(RectQuestPanel6, position + 290f, time);
        Invoke("Creier", time2);
    }

    //-----------------------------------------------------------------------


    public void LoadMainMenu()
    {
        Transitions.scena = 0;
        SceneManager.LoadScene(1);
    }

    public void Select(string levelName)
    {
        int.TryParse(levelName, out Transitions.scena);
        Time.timeScale = 1f;
        // rezolvare eroare freeze 
        SceneManager.LoadScene(1);
    }

    public void Creier()
    {
        CameraMove = true;
    }

}