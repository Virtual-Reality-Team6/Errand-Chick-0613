using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloNPCVR : MonoBehaviour
{
    public GameObject HelloFirstPanel;
    public GameObject HelloSecondPanel;
    public GameObject HelloCorrectPanel;
    public GameObject HelloWrongPanel;

    void Awake()
    {
        HideAllPanel();
    }

    public void HideAllPanel()
    {
        HelloFirstPanel.SetActive(false);
        HelloSecondPanel.SetActive(false);
        HelloCorrectPanel.SetActive(false);
        HelloWrongPanel.SetActive(false);
    }
    
    public void StartHelloInteraction()
    {
        HideAllPanel();
        HelloFirstPanel.SetActive(true);
    }

    public void SecondHelloInteraction()
    {
        HideAllPanel();
        HelloSecondPanel.SetActive(true);
    }

    public void CorrectAnswerChoice()
    {
        HideAllPanel();
        HelloCorrectPanel.SetActive(true);
    }

    public void WrongAnswerChoice()
    {
        HideAllPanel();
        HelloWrongPanel.SetActive(true);
    }

}