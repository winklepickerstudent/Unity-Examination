using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField] float speed, maxSpeed;
	[SerializeField] Animator animator;
	[SerializeField] Rigidbody2D rb;
	[SerializeField] Vector2 projectileSpawnPoint;
	[SerializeField] GameObject projectile;
	[SerializeField] AudioSource projectileSFX;


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
		moveInput = context.ReadValue<Vector2>();
		if (moveInput.x != 0)
		{
			animator.SetBool("Moving", true);
		}
		else 
		{
			animator.SetBool("Moving", false);
		}
	}

	public void OnAttack(InputAction.CallbackContext context)
	{
		Instantiate(projectile, new Vector3(projectileSpawnPoint.x, projectileSpawnPoint.y, 0) + transform.position, Quaternion.identity);
		projectileSFX.Play();
	}
}
