using UnityEngine;
using UnityEngine.UI;

public class ConfigureText : MonoBehaviour
{
	private void Start()
	{
		GetComponent<Text>().text = transform.parent.name;
	}
}