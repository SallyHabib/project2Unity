using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleScreen : MonoBehaviour {
    public GameObject start;
    public GameObject quit;
    public GameObject moreInfo;
    public GameObject credit;
    public GameObject ok;
    public GameObject moreInfoText;
    public GameObject creditsText;
    public AudioSource title;

    // Use this for initialization
    void Start () {
        title.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Quitzozo()
    {
        Debug.Log("sally");
        Application.Quit();
    }
    public void NextScene()
    {
        title.Stop();
        SceneManager.LoadScene("SampleScene");
    }
    public void more()
    {
        start.gameObject.SetActive(false);
        credit.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
        moreInfo.gameObject.SetActive(false);
        ok.gameObject.SetActive(true);
        moreInfoText.SetActive(true);
        creditsText.SetActive(false);
    }

    public void creditButton()
    {
        start.gameObject.SetActive(false);
        credit.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);
        moreInfo.gameObject.SetActive(false);
        ok.gameObject.SetActive(true);
        moreInfoText.SetActive(false);
        creditsText.SetActive(true);
    }
    public void okButton()
    {
        start.gameObject.SetActive(true);
        credit.gameObject.SetActive(true);
        quit.gameObject.SetActive(true);
        moreInfo.gameObject.SetActive(true);
        ok.gameObject.SetActive(false);
        moreInfoText.SetActive(false);
        creditsText.SetActive(false);
    }
}
