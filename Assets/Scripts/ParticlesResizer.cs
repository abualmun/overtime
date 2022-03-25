using UnityEngine;

public class ParticlesResizer : MonoBehaviour {
    public float min;
    public float max;

    private new ParticleSystem particleSystem;
    private AudioManager audioManager;

    private void Start() {
        particleSystem = GetComponent<ParticleSystem>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void Update() {
        var particles = new ParticleSystem.Particle[particleSystem.particleCount];
        var audioValue = audioManager.GetValue(min, max);
        particleSystem.GetParticles(particles);
        for (int i = 0; i < particleSystem.particleCount; i++) {
            particles[i].startSize = audioValue;
        }
        particleSystem.SetParticles(particles);
    }

}
