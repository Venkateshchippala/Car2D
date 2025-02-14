using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoveing : MonoBehaviour
{
    private CarsCrashing carcrashing;
    public GameObject[] roads;
    // Start is called before the first frame update
    void Start()
    {
        carcrashing = FindObjectOfType<CarsCrashing>();
    }

    // Update is called once per frame
    void Update()
    {
        GameStatus();
    }

    private void GameStatus()
    {
        if (carcrashing.isplay == true)
        {
            RoadsMovecontrolling();

        }
    }

    private void RoadsMovecontrolling()
    {
        for(int i = 0; i < roads.Length; i++)
        {
            roads[i].transform.localPosition += new Vector3(0, -1 *Time.deltaTime* 8f, 0);
        }
        if (roads[0].transform.localPosition.y < -17f)
        {
            roads[0].transform.localPosition = roads[1].transform.localPosition + new Vector3(0,15.336f,0);
        }
        if (roads[1].transform.localPosition.y < -14f)
        {
            roads[1].transform.localPosition = roads[0].transform.localPosition + new Vector3(0, 15.336f, 0);
        }
    }
}
