using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceSideWalk : MonoBehaviour
{
    public GameObject choiceQuestion;
    public GameObject target;
    private Player player;

    public int interactionIndex;

    public GameObject result1;
    public GameObject result2;
    public GameObject oneMoreObj;

    void Awake()
    {
        player = target.GetComponent<Player>();
    }

    public void CorrectChoice()
    {
        choiceQuestion.SetActive(false);
        result1.SetActive(true);
        player.iscompletedStamp[interactionIndex] = true;
    }

    public void WrongChoice()
    {
        choiceQuestion.SetActive(false);
        result2.SetActive(true);
        oneMoreObj.SetActive(true);

    }

    public void oneMore()
    {
        result1.SetActive(false);
        result2.SetActive(false);
        choiceQuestion.SetActive(true);
        oneMoreObj.SetActive(false);
    }
}
