using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaySpawner : MonoBehaviour
{

    public GameObject day;

    void SpawnDay(Vector2 pos) {
        Object.Instantiate(day, pos, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 7; i++) {
            
            Vector2 posi = new Vector2((i - 6) * 1 , 0);

            SpawnDay(posi);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
