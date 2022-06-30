using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


[CreateAssetMenu]

public class IntData : ScriptableObject
{
	public UnityEvent onZeroEvent;
	public int value;

	public void UpdateValue(int number)
	{
		value += number;
	}

	public void ReplaceValue(int number)
	{
		value = number;
	}

	public void DisplayImage(Image img)
	{
		if (value <= 10)
		{
			onZeroEvent.Invoke();
		} else if (value >= 20)
		{
			value = 25;
		}

		img.fillAmount = value;
	}


	public void DisplayNumber(Text txt)
	{
		txt.text = value.ToString();
	}
}
