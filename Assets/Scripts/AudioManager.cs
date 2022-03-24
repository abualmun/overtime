using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using Files = SimpleFileBrowser.FileBrowser;

public class AudioManager : MonoBehaviour {

    private float audioValue;
    private static AudioClip clip;

    public GameObject cube; // * Debug
    public List<Transform> cubes = new List<Transform>(12); // * DEBUG

    void Start() {
        DontDestroyOnLoad(this);
        // find a way to assign [clip] to audio processor
        for (var i = 0; i < 12; i++) {
            cubes.Add(Instantiate(cube.transform, transform.right * i, Quaternion.identity));
        }
    }

    public void AssignAudioProcessor(AudioProcessor audioProcessor) {
        audioProcessor.onSpectrum.AddListener(onSpectrum);
        audioProcessor.GetComponent<AudioSource>().clip = clip;
    }

    void Update() { }

    public float GetValue(float min = 0, float max = 1) {
        return min + audioValue * (max - min);
    }

    //This event will be called every frame while music is playing
    void onSpectrum(float[] spectrum) {
        //The spectrum is logarithmically averaged
        //to 12 bands

        // max range is 11, the beat is in low spectrums
        audioValue = spectrum.ToList().GetRange(3, 6).Average();

        // * Debug
        for (int i = 0; i < spectrum.Length; ++i) {
            Vector3 start = new Vector3(i, 0, 0);
            Vector3 end = new Vector3(i, spectrum[i], 0);
            cubes[i].localScale = new Vector3(0.5f, spectrum[i] * 5, 0.5f);
        }
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

}
