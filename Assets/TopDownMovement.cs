using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

	public float walkSpeed = 5f;

	float maxSpeed = 5f;
	float curSpeed;

	float sprintSpeed;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		// sprintSpeed = walkSpeed + (walkSpeed / 2);
	}

	void FixedUpdate()
	{
		curSpeed = walkSpeed;
		maxSpeed = curSpeed;

		// the movement magic
		rb.velocity = new Vector3(
			Mathf.Lerp(0, Input.GetAxis("Horizontal") * curSpeed, 0.8f),
			rb.velocity.y,
			Mathf.Lerp(0, Input.GetAxis("Vertical") * curSpeed, 0.8f)
		);
	}
}

