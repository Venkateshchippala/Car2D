using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UiHandler : MonoBehaviour
{
    private CarsCrashing carcrashing;
    public GameObject[] panels;
    public TextMeshProUGUI highestValTxt;
    public TextMeshProUGUI levelValTxt;
    public int hightVal=0;
    public int levleVal=0;
    
    // Start is called before the first frame update
    void Start()
    {
        carcrashing = FindObjectOfType<CarsCrashing>();
        DefaultActivePanels();
        highestValTxt.text = " " + hightVal;
        levelValTxt.text = " " + levleVal;
        hightVal = PlayerPrefs.GetInt("highscore", 0);
    }

    private void DefaultActivePanels()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].gameObject.SetActive(false);
        }
        panels[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play_Btn_Click()
    {
        panels[0].gameObject.SetActive(false);
        carcrashing.isplay = true;
    }
    public void Retry_Btn_Click()
    {
        panels[1].gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }

}
