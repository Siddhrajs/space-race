using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text Score;
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            Score.text = player.position.z.ToString("0");
        }
        if(Score.text=="212")
        {
            FindObjectOfType<GameManagement>().CompleteLevel();
        }
	}
}
