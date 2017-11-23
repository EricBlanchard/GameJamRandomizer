using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOption : MonoBehaviour {

    public List<string> options = new List<string>();
    public TextMeshProUGUI TXTlabel;
    public TextMeshProUGUI TXTresult;
    public Toggle toggle;
    public bool canReroll = true;
    public string result = "";
}