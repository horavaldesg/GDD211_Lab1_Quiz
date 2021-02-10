using UnityEngine;

/// <summary>
/// Control Puppy 2 by setting parameter values on the animator and using a blend tree to control the motion.
/// This is the type of animation seen in the Lab 1 project folder: "3. Blend Trees".
/// </summary>

public class BlendTree : MonoBehaviour
{
	[SerializeField] private Animator puppy2Animator;
	private float speed;
	private float inp;
	private void Update()
	{
		inp = Input.GetAxisRaw("Vertical");
		if (Input.GetAxisRaw("Vertical") > 0f) //Walk
		{
			speed = 1;
			puppy2Animator.SetFloat("Speed", inp);
		}
		else //Idle
		{
			speed = 0;
			puppy2Animator.SetFloat("Speed", inp);
		}

		transform.position += new Vector3(Time.deltaTime * 0.32f * speed, 0f);
	}
}
