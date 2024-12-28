using UnityEngine;

public class BGMScript : MonoBehaviour
{
    public AudioSource bgmMusic;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        bgmMusic = GetComponent<AudioSource>();
    }
    public void PlayMusic()
    {
        if (bgmMusic.isPlaying) return;
        bgmMusic.Play();
    }

    public void StopMusic()
    {
        bgmMusic.Stop();
    }
}
