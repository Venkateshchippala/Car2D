using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private CarsCrashing carcrashing;
    private float[] positions = { -1.5f, 0, 1.5f };
    private int currentposition = 1;
    public GameObject playerCar;
    
    // Start is called before the first frame update
    void Start()
    {
        carcrashing = FindObjectOfType<CarsCrashing>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Arrow_Btn_Click(int val)
    {
        if (carcrashing.isplay == true)
        {
            currentposition += val;
            currentposition = Mathf.Clamp(currentposition, 0, positions.Length - 1);
            float pos = positions[currentposition];
            playerCar.transform.localPosition = new Vector3(pos, playerCar.transform.localPosition.y, playerCar.transform.localPosition.z);
        }

    }

}
