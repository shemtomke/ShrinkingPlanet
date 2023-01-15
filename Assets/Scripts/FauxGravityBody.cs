using UnityEngine;
using FirstGearGames.SmoothCameraShaker;

[RequireComponent(typeof(Rigidbody))]
public class FauxGravityBody : MonoBehaviour {

	private FauxGravityAttractor attractor;
	private Rigidbody rb;

	private CameraShake camShake;

	public bool placeOnSurface = false;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		camShake = FindObjectOfType<CameraShake>();
		attractor = FauxGravityAttractor.instance;
	}
	
	void FixedUpdate ()
	{
		if (placeOnSurface)
			attractor.PlaceOnSurface(rb);
		else
			attractor.Attract(rb);
	}
	public void StartShaking()
    {
		CameraShakerHandler.Shake(camShake.shakeData);
    }
}
