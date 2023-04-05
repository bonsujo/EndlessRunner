using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectorController : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinText;

    // Update is called once per frame
    void Update()
    {   
        coinText.GetComponent<Text>().text = "" + coinCount; 
    }
}
