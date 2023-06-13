using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crosswalk_2 : MonoBehaviour
{
    public GameObject Player;

    public int interactionIndex;

    public GameObject D;
    public GameObject oculus;
    public GameObject clearcross;
    public GameObject failcross;

    public GameObject subbox1;
    public GameObject subbox2;
    public GameObject subbox3;
    public GameObject subbox4;
    public GameObject subbox5;

    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;

    public GameObject clear;
    public GameObject fail;


    private WaitForSeconds _UIDelay1 = new WaitForSeconds(10.0f);
    private float distance;
    bool timeup;
    bool success;
    int done, coroutine;

    // Start is called before the first frame update
    void Start()
    {
        timeup = false;
        success = false;
        done = 0;
        coroutine = 0;

        clear.SetActive(false);
        fail.SetActive(false);

        subbox1.SetActive(true);
        subbox2.SetActive(true);
        subbox3.SetActive(true);
        subbox4.SetActive(true);
        subbox5.SetActive(true);

        StopAllCoroutines();
        StartCoroutine(delay1());


    }

    // Update is called once per frame
    void Update()
    {
        if (done != 1)
        {
            Player player = GameObject.Find("Player").GetComponent<Player>();
            

            if (one.activeSelf == false && two.activeSelf == false && three.activeSelf == false && four.activeSelf == false && five.activeSelf == false && six.activeSelf == false)
            {
            Debug.Log("great job!");
            success = true;
            StopCoroutine("delay1");
            StartCoroutine(clear1());
            player.iscompletedStamp[interactionIndex] = true;
                if (coroutine == 1)
                {
                    Debug.Log("ok");
                }
            }
        }

        


    }

    public void Change()
    {
        SceneManager.LoadScene("SimpleTown_DemoScene");
    }

    IEnumerator delay1()
    {
        D.SetActive(true);
        yield return _UIDelay1;
        D.SetActive(false);

        yield return _UIDelay1;
        subbox1.SetActive(false);

        yield return _UIDelay1;
        subbox2.SetActive(false);

        yield return _UIDelay1;
        subbox3.SetActive(false);

        yield return _UIDelay1;
        subbox4.SetActive(false);

        yield return _UIDelay1;
        subbox5.SetActive(false);

        Debug.Log("times up!");
        timeup = true;
        done = 1;

        fail.SetActive(true);
        yield return _UIDelay1;
        fail.SetActive(false);


    }

    IEnumerator clear1()
    {
        clear.SetActive(true);
        yield return _UIDelay1;
        clear.SetActive(false);
        done = 1;
        coroutine = 1;
    }


}