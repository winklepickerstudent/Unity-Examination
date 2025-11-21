using UnityEngine;

public class VolumeSetter : MonoBehaviour
{
	[SerializeField] AudioSource source;
	public void SetVolume(System.Single s)
	{
		source.volume = s;
	}

	public void SetAllVolume(System.Single s)
	{
		var foundAudioSources = FindObjectsOfType<VolumeSetter>();
		foreach(VolumeSetter source in foundAudioSources)
		{
			source.SetVolume(s);
		}
	}
}
