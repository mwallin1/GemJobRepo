using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerModel : MonoBehaviour
{
    public GameObject model1;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;
    public GameObject model5;
    public GameObject model6;

    public bool zombSuit = false;
    public bool guardSuit = false;
    public bool trashSuit = false;
   
    
    

    void Start()
    {
        model1.gameObject.SetActive(true);
        model2.gameObject.SetActive(false);
        model3.gameObject.SetActive(false);
        model4.gameObject.SetActive(false);
        model5.gameObject.SetActive(false);
        model6.gameObject.SetActive(false);
    }

    public void switchModelZombie()
    {
        zombSuit = true;
        guardSuit = false;
        trashSuit = false;
        
        model1.gameObject.SetActive(false);
        model2.gameObject.SetActive(true);
        model3.gameObject.SetActive(false);
        model4.gameObject.SetActive(false);
        model5.gameObject.SetActive(false);
        model6.gameObject.SetActive(false);
    }

    public void switchModelSanta()
    {
        
        zombSuit = false;
        guardSuit = false;
        trashSuit = false;

        model1.gameObject.SetActive(false);
        model2.gameObject.SetActive(false);
        model3.gameObject.SetActive(true);
        model4.gameObject.SetActive(false);
        model5.gameObject.SetActive(false);
        model6.gameObject.SetActive(false);
    }

    public void switchModelSoccer()
    {
        
        zombSuit = false;
        guardSuit = false;
        trashSuit = false;

        model1.gameObject.SetActive(false);
        model2.gameObject.SetActive(false);
        model3.gameObject.SetActive(false);
        model4.gameObject.SetActive(true);
        model5.gameObject.SetActive(false);
        model6.gameObject.SetActive(false);

    }

    public void switchModelGuard()
    {

        zombSuit = false;
        guardSuit = true;
        trashSuit = false;

        model1.gameObject.SetActive(false);
        model2.gameObject.SetActive(false);
        model3.gameObject.SetActive(false);
        model4.gameObject.SetActive(false);
        model5.gameObject.SetActive(true);
        model6.gameObject.SetActive(false);

    }

    public void switchModelTrash() {
        zombSuit = false;
        guardSuit = false;
        trashSuit = true;

        model1.gameObject.SetActive(false);
        model2.gameObject.SetActive(false);
        model3.gameObject.SetActive(false);
        model4.gameObject.SetActive(false);
        model5.gameObject.SetActive(false);
        model6.gameObject.SetActive(true);

    }
}
