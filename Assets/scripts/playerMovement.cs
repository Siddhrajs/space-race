using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce=8000f;
	public float sidewayForce=120f;
	private float yposition = 0.86f;
    public void moveLeft()
    {
        rb.AddForce(-1 * sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        rb.transform.Rotate(0, 0, 1);
        Debug.Log("Left");
    }

    public void moveRight()
    {
        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        rb.transform.Rotate(0, 0, -1);
        Debug.Log("Right");
    }

    //fixed because we are using mess in physics
    void FixedUpdate ()
	{
		//add forward force to player;
		rb.AddForce (0, 0, forwardForce*Time.deltaTime);
		if (Input.GetKey ("d"))
		{
            moveRight();
		}
		if (Input.GetKey ("a"))
		{
            moveLeft();
		}
        if(rb.position.y<yposition)
        {
            FindObjectOfType<GameManagement>().EndGame();
        }
	}
    
}