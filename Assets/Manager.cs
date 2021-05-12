using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Manager : MonoBehaviour
{
    bool endGame = false;
    bool gameWon = false;
    public loseScreen ls;
    public winScreen ws;
    


    public void gameOver() {
        if (endGame == false) {
            endGame = true;
            FindObjectOfType<AudioManager>().Mute("Theme");
            FindObjectOfType<AudioManager>().Mute("Christmas");
            FindObjectOfType<AudioManager>().Mute("Grunt");
            FindObjectOfType<AudioManager>().Play("Sirens");
            ls.toggleLoseScreen();
            ls.showing = true;
        }
    }

    public void endScreen() {
        if (gameWon == false) {
            gameWon = true;
            FindObjectOfType<AudioManager>().Mute("Theme");
            FindObjectOfType<AudioManager>().Mute("Christmas");
            
            FindObjectOfType<AudioManager>().Play("Win");
            ws.toggleWinScreen();
            ws.showing = true;
        }
    }

    public void gameOverC()
    {
        if (endGame == false)
        {
            endGame = true;
            FindObjectOfType<AudioManager>().Play("Caught");
            FindObjectOfType<AudioManager>().Mute("Theme");
            FindObjectOfType<AudioManager>().Mute("Christmas");
            FindObjectOfType<AudioManager>().Mute("Grunt");
            FindObjectOfType<AudioManager>().Play("Sirens");
            ls.toggleLoseScreen();
            ls.showing = true;
        }
    }





}
