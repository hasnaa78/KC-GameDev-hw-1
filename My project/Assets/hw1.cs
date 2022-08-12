using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw1 : MonoBehaviour
{
    // Start is called before the first frame update
    string heroname = "zezo";
    int health = 100;

    void Start()
    {
        damaged(20);

    }

    // Update is called once per frame
    void Update()
    {

    }
    int damaged(int damaged) 
    {
        health = health - damaged;
        return health;
    }
}
