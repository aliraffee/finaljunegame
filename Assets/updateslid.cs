using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updateslid : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slid;
    public TextMeshProUGUI value;
    private void FixedUpdate()
  
    {
       
        value.text = slid.value.ToString();
    }
}
