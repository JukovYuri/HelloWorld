using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersTest : MonoBehaviour

    
{
    int number = 0;
    // Start is called before the first frame update
    void Start()
    {
        number = 60;

    }

    // Update is called once per frame
    void Update()
    {
        //number = number + 1;
        number++;
        print(number);
        
    }
}
