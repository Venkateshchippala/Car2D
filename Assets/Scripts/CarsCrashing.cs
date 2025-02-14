using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsCrashing : MonoBehaviour
{
    private UiHandler uihandler;
    public bool isplay = false;
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
            isplay = false;
            uihandler.panels[1].gameObject.SetActive(true);

        }
    }
}


