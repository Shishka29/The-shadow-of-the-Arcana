using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class MusicManager : MonoBehaviour
{
    [System.Serializable]
    public struct LevelMusic
    {
        public string levelName;
        public AudioClip musicClip;
    }

    public static MusicManager Instance { get; private set; }


    public List<LevelMusic> levelMusicList = new List<LevelMusic>();
    private AudioSource audioSource;
    private string currentLevelName;
    private bool changingMusic;
    private float fadeSpeed = 0.8f;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ChangeMusic();

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ChangeMusic();
    }

    public void ChangeMusic()
    {
        if (changingMusic) return;
        string newLevelName = SceneManager.GetActiveScene().name;
        if (newLevelName == currentLevelName) return;
        StartCoroutine(StartChangeMusic(newLevelName));
    }

    private IEnumerator StartChangeMusic(string levelName)
    {
        changingMusic = true;
        if (audioSource.isPlaying)
            yield return StartCoroutine(FadeOut());
        AudioClip newMusic = GetMusicClipForLevel(levelName);
        if (newMusic != null)
        {
            audioSource.clip = newMusic;
            yield return StartCoroutine(FadeIn());
            audioSource.Play();

        }
        currentLevelName = levelName;
        changingMusic = false;
    }


    private IEnumerator FadeIn()
    {
        audioSource.volume = 0f;
        while (audioSource.volume < 1)
        {
            audioSource.volume += Time.deltaTime * fadeSpeed;
            yield return null;
        }

        audioSource.volume = 1f;
    }

    private IEnumerator FadeOut()
    {
        while (audioSource.volume > 0)
        {
            audioSource.volume -= Time.deltaTime * fadeSpeed;
            yield return null;
        }
        audioSource.Stop();
        audioSource.volume = 0;
    }

    private AudioClip GetMusicClipForLevel(string levelName)
    {
        foreach (LevelMusic levelMusic in levelMusicList)
        {
            if (levelMusic.levelName == levelName)
            {
                return levelMusic.musicClip;
            }
        }
        return null;
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
