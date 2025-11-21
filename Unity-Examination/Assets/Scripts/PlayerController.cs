using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField] float speed, maxSpeed;
	[SerializeField] Animator animator;
	[SerializeField] Rigidbody2D rb;


	private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(rb.linearVelocity.x) < maxSpeed)
	{
		rb.AddForce(transform.right * moveInput.x * speed * Time.deltaTime);
	}
    }

	public void OnMove(InputAction.CallbackContext context)
	{
		Debug.Log("Gets input");
		moveInput = context.ReadValue<Vector2>();
	}
}
