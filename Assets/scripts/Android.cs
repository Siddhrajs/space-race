using UnityEngine;

public class Android : MonoBehaviour {

    bool hasLeftPressed = false;
    bool hasRightPressed = false;
    public playerMovement player;

    public void leftTrue()
    {
        hasLeftPressed = true;
    }

    public void leftFalse()
    {
        hasLeftPressed = false;
    }

    public void rightTrue()
    {
        hasRightPressed = true;
    }
	
    public void righFalse()
    {
        hasRightPressed = false;
    }

	// Update is called once per frame
	void Update () {
        if (hasLeftPressed)
            player.moveLeft();
        if (hasRightPressed)
            player.moveRight();
	}
}
