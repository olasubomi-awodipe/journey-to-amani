using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BraceletManager : MonoBehaviour
{
    public int braceletCount;
    public TMP_Text braceletText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        braceletText.text = "Bracelet count: " + braceletCount.ToString();
    }
}
