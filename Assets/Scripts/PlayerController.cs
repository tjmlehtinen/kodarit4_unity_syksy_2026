using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("koodi yhdistetty peliobjektiin: " + name);
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log(verticalInput);
    }
}
