using UnityEngine;

public class Context : MonoBehaviour
{
	[SerializeField]
	private GameObject _troll;

	public void SwitchAnimation(string animationName)
	{
		_troll.GetComponent<Animation>().Play(animationName);
	}
}