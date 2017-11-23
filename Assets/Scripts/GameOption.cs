using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOption : MonoBehaviour {

    public string[] options;
    public TextMeshProUGUI TXTlabel;
    public TextMeshProUGUI TXTresult;
    public Toggle toggle;
    public bool canReroll = true;
    public string result = "";

    public TextAsset textFile;

    private void Start()
    {
        options = textFile.text.Split(',');
    }

    public void Update()
    {
        canReroll = !toggle.isOn;
        TXTresult.text = result;
    }
}