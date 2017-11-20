using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOption : MonoBehaviour {

    public List<string> options = new List<string>();
    public Text TXTlabel;
    public Text TXTresult;
    public bool canReroll = true;
    public string result = "";
}
