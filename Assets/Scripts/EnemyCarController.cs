using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarController : MonoBehaviour
{
    private CarsCrashing carscrashing;
    public GameObject[] enemyCars;
    // Start is called before the first frame update
    void Start()
    {
        carscrashing = FindObjectOfType<CarsCrashing>();
    }

    // Update is called once per frame
    void Update()
    {
        GameStatus();
    }

    private void GameStatus()
    {
        if (carscrashing.isplay == true)
        {
            EnemycarsMoving();

        }
    }

    public void EnemycarsMoving()
    {
        for (int i = 0; i < enemyCars.Length; i++)
        {
            enemyCars[i].transform.localPosition += new Vector3(0, -1 * Time.deltaTime * 8f, 0);
        }
        if (enemyCars[0].transform.localPosition.y < -30f)
        {
            enemyCars[0].transform.localPosition = enemyCars[1].transform.localPosition + new Vector3(0,30.616f,0) ;
        }
        if (enemyCars[1].transform.localPosition.y < -30f)
        {
            enemyCars[1].transform.localPosition = enemyCars[0].transform.localPosition + new Vector3(0, 30.616f, 0);
        }
    }
}
