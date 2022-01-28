using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;
    int chooseObstacle;

    public GameObject obstacle1;
    public GameObject obstacle2;

    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime) {
            GenerateObstacle();
            timer = 0;
        }
    }

    void GenerateObstacle() {
        chooseObstacle = Random.Range(1, 3);
        switch (chooseObstacle) {
            case 1:
                Instantiate(obstacle1);
                break;
            case 2:
                Instantiate(obstacle2);
                break;
        }
    }
}
