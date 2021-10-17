using UnityEngine;
 [RequireComponent(typeof(AudioSource))]
public class SoundOption : MonoBehaviour {
 
	private AudioSource audioSource;


	private void Start()
	{
		audioSource = gameObject.GetComponent<AudioSource>();
	}

	public void SoundSliderOnValueChange(float newSliderValue)
	{
		// 音楽の音量をスライドバーの値に変更
		audioSource.volume = newSliderValue;
	}
}