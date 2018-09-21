using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
   
	public Text winText;

    public float speed;
    public Text countText;

    void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
    void FixedUpdate ()
	{
		if (count >= 12)
			return;
		float mvHorizontal = Input.GetAxis ("Horizontal");
		float mvVertical = Input.GetAxis ("Vertical");

		Vector3 mv = new Vector3 (mvHorizontal, 0.0f, mvVertical);

		rb.AddForce (mv * speed);
	}


	void SetCountText ()
	{
		countText.text = ((count <= 1) ? "Cubes Collected: " : "Cubes Collected: ") + count.ToString ();
		if (count >= 12) winText.text = "Winner!";
	}
}