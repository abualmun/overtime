using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using Files = SimpleFileBrowser.FileBrowser;

public class AudioManager : MonoBehaviour {
    private float audioValue;
    private static AudioClip clip;

    void Start() {
        DontDestroyOnLoad(this);
    }

    public void AssignAudioProcessor(AudioProcessor audioProcessor) {
        audioProcessor.onSpectrum.AddListener(onSpectrum);
        if (clip != null)
            audioProcessor.GetComponent<AudioSource>().clip = clip;
    }

    void Update() {
    }

    public float GetValue(float min = 0, float max = 1) {
        return min + audioValue * (max - min);
    }

    //This event will be called every frame while music is playing
    void onSpectrum(float[] spectrum) {
        //The spectrum is logarithmically averaged
        //to 12 bands

        // max range is 11, the beat is in low spectrums
        audioValue = spectrum.ToList().GetRange(3, 6).Average();
    }

    public void SelectMusic() {
        Files.ShowLoadDialog((string[] paths) => {
            StartCoroutine(LoadMusic(paths[0]));
        }, null, Files.PickMode.Files);
        Files.SetFilters(true, ".mp3");
        Files.SetDefaultFilter(".mp3");
    }

    IEnumerator LoadMusic(string path) {
        UnityWebRequest req = UnityWebRequestMultimedia.GetAudioClip("file://" + path, AudioType.MPEG);
        yield return req.SendWebRequest();

        var audioClip = DownloadHandlerAudioClip.GetContent(req);
        clip = audioClip;
    }

    public void PlaySound(SoundsEnum sound) {
        // enum to sound(sound)
        // Play sound
    }
}

[System.Serializable]
public class Sound {
    public string name;
    public AudioSource audioSource;
}

public enum SoundsEnum {

}

