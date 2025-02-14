using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    private UiHandler uihandler;
    // Start is called before the first frame update
    void Start()
    {
        uihandler = FindObjectOfType<UiHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            uihandler.hightVal += 1;
            uihandler.levleVal += 1;
            uihandler.highestValTxt.text = uihandler.hightVal.ToString();
            uihandler.levelValTxt.text = uihandler.levleVal.ToString();
            PlayerPrefs.SetInt("highscore", uihandler.hightVal);
            uihandler.hightVal = PlayerPrefs.GetInt("highscore");
            
        }
    }
}
