using UnityEngine;

public class Destructible : MonoBehaviour {

    public GameObject destroyedVersion;

    private void OnTriggerEnter()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
        FindObjectOfType<GameManagement>().EndGame();
    }

}
