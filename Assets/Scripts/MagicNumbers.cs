using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
	public int min = 1;
	public int max = 1000;
	int guess;

	// Start is called before the first frame update
	void Start()
	{
		//min = 1;
		//max = 1000;
		print($"загадайте число от {min} до {max}");
		UpdateGuess();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			UpdateGuess();
		}

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			UpdateGuess();
		}

		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
		{

			print("Угадал!!!");
			Start();
		}

	}

	void UpdateGuess()
		{
		guess = (min + max) / 2;
		print($"ваше число {guess} ???");
	}
}
