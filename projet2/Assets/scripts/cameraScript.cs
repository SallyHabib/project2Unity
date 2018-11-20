using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cameraScript : MonoBehaviour {
    public Camera mainCamera;
    public Camera TopCamera;
    public GameObject red;
    public GameObject pauseObjects;
    public AudioSource background;


    // Use this for initialization
    void Start () {
        mainCamera.enabled = true;
        TopCamera.enabled = false;
        background.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            TopCamera.enabled = !TopCamera.enabled;
        }

        if (Input.GetKeyDown("escape"))
        {
            if (Time.timeScale == 1)
            {
  
                Time.timeScale = 0;
                showPaused();
            }
            else
            {
                if (Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    hidePaused();


                }
            }

        }
    }

    public void showPaused()
    {
        pauseObjects.SetActive(true);
    }
    public void hidePaused()
    {
        pauseObjects.SetActive(false);
    }
    public void resume()
    {
        pauseObjects.SetActive(false);
        Time.timeScale = 1f;
    }
    public void backToMenu()
    {
        background.Stop();
        SceneManager.LoadScene("startScene");
    }
}
