using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loseScreen : MonoBehaviour
{

    public Image backgroundImg;
    private float transition = 0.0f;

    public bool showing = false;
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!showing) {
            return;
        }
        transition += Time.deltaTime;
        backgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);
    }

    public void toggleLoseScreen(){
        gameObject.SetActive(true); 
    }

    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit() {
        Application.Quit();
    }
}
