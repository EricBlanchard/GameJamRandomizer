using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public List<GameOption> gameOptions = new List<GameOption>();

    void GenerateNewGame()
    {
        for (int i = 0; i < gameOptions.Count; i++)
        {
            if (gameOptions[i].canReroll)
            {
                int temp = Random.Range(0, gameOptions[i].options.Count);
                gameOptions[i].result = gameOptions[i].options[temp];
            }
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
