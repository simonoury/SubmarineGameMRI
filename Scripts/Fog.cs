using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Fog : MonoBehaviour {
    SerialPort sp = new SerialPort("/dev/cu.usbmodem14201", 9600); //change this to appropriate port name
    public GameObject fogUI;

    void Start ()
    {
      sp.Open();
      sp.ReadTimeout = 1;

    }

    void Update()
    {
      while(true)
      {
        string text = "";
        text = sp.ReadExisting();
        if (text == "fog"){
          fogUI.SetActive(true);
        }
      }
    }

}
