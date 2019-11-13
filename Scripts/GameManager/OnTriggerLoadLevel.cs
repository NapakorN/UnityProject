using UnityEngine;

public class OnTriggerLoadLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject;

    public string Leveltoload;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            gameObject.SetActive(true);
            if(gameObject && Input.GetKey("e"))
            {
                Application.LoadLevel(Leveltoload);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
    }
}
