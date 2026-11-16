using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("koodi yhdistetty peliobjektiin: " + name);
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float sideInput = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(sideInput, -1, forwardInput);

        controller.Move(direction * speed * Time.deltaTime);
    }
}
