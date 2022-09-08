using UnityEngine;

public class JS_PlayerRotation : MonoBehaviour
{

	[SerializeField] private JoyStick joystick;//Joystick reference for assign in inspector

	void Update()
	{
		float angle = Mathf.Atan2(joystick.Horizontal, joystick.Vertical) * Mathf.Rad2Deg;
		this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angle));
	}
}