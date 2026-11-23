using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;
    public float speed = 5f;
    private float mouseMovement = 0f;
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
        mouseMovement += Input.GetAxis("Mouse X");

        Vector3 direction = new Vector3(sideInput, -1, forwardInput);
        transform.localRotation = Quaternion.Euler(0, mouseMovement, 0);
        direction = transform.rotation * direction;

        controller.Move(direction * speed * Time.deltaTime);

        animator.SetFloat("Speed", Mathf.Abs(forwardInput) + Mathf.Abs(sideInput));
    }
}
