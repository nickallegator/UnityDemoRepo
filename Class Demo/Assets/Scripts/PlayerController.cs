using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

	public float speed = 6.0F;
	public float gravity = 20.0F;

	public float horizontalSpeed = 2.0F;
	public float verticalSpeed = 2.0F;

	public ScoreBehavior score;

	private Vector3 moveDirection = Vector3.zero;
	public CharacterController controller;

	Health health;

	void Start()
	{
		// Store reference to attached component
		controller = GetComponent<CharacterController>();
		Cursor.visible = false;
		health = GetComponent<Health>();

	}

	void Update()
	{
		// Character is on ground (built-in functionality of Character Controller)
		if (controller.isGrounded)
		{
			// Use input up and down for direction, multiplied by speed
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
		}

		float h = horizontalSpeed * Input.GetAxis("Mouse X");
		float v = verticalSpeed * Input.GetAxis("Mouse Y");

		// Apply gravity manually.
		moveDirection.y -= gravity * Time.deltaTime;
		// Move Character Controller
		controller.Move(moveDirection * Time.deltaTime);
		controller.transform.Rotate(0, h, 0);
	}
	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "Hazard")
		{
			KillPlayer();
		}
		else if (hit.tag == "Point")
		{
			ScoreBehavior.AddScore();
            Destroy(hit.gameObject);

		}
		else if (hit.tag == "Damage")
		{
			health.OnDamage(20);
		}
	}

	public void KillPlayer()
	{
		Cursor.visible = true;
		SceneManager.LoadScene("MainMenu");
	}
}
