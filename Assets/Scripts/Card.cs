using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public int suit;
    public int rank; 
    
    // Start is called before the first frame update
    
    //Lookie here my dude it doesnt say start instead i replaced it with something else
    void Awake()
    {
        Debug.Log("My card was made");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
