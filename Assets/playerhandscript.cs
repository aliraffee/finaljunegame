using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]public class playerhandscript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[] poneavailableslot;
    public Transform[] playerslot;
    void Start()
    {
        for (int i = 0; poneavailableslot.Length > i; i++)
        {
            poneavailableslot[i]= true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
