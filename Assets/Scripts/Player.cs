using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public SpriteRenderer PlayerSprite;
	public Sprite Sprite1;
	public Sprite Sprite2;
	public float PlayerSpeed;

    void Update()
    {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-PlayerSpeed, 0f, 0f);
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(PlayerSpeed, 0f, 0f);
		}

		if(transform.position.x > 0f)
		{
			PlayerSprite.sprite = Sprite2;
		}
		else if (transform.position.x < 0f)
		{
			PlayerSprite.sprite = Sprite1;
		}

	}
}
