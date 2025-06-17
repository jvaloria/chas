using GifImporter;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Linq;

namespace GifImporter
{
    [ExecuteAlways]
    public class GifPlayer : MonoBehaviour
    {
        public Gif Gif;
        public bool holdOnFirstFrame = false;
        public int startingFrameIndex = 0;
        public bool resetToStartAfterPlayOnce = false;

        public UnityEvent OnPlayOnceComplete;

        private int _index;
        private float _flip;
        private Gif _setGif;

        private bool _playOnceForward = false;
        private bool _playOnceReverse = false;
        private bool _playingOneShot = false;

        private void OnEnable()
        {
            if (Gif == null) return;
            var frames = Gif.Frames;
            if (frames == null || frames.Count == 0) return;

            startingFrameIndex = Mathf.Clamp(startingFrameIndex, 0, frames.Count - 1);
            _index = startingFrameIndex;

            Apply(frames[_index]);
        }

        private void Update()
        {
            if (Gif == null || holdOnFirstFrame) return;
            var frames = Gif.Frames;
            if (frames == null || frames.Count == 0) return;
            int frameCount = frames.Count;

            // Handle one-shot playback
            if (_playingOneShot && Application.isPlaying)
            {
                if (_flip < Time.time)
                {
                    if (_playOnceForward)
                    {
                        if (_index < frameCount - 1)
                        {
                            _index++;
                            Apply(frames[_index]);
                        }
                        else
                        {
                            _playingOneShot = false;
                            _playOnceForward = false;
                            if (resetToStartAfterPlayOnce)
                            {
                                _index = startingFrameIndex;
                                Apply(frames[_index]);
                            }
                            OnPlayOnceComplete?.Invoke();
                        }
                    }
                    else if (_playOnceReverse)
                    {
                        if (_index > 0)
                        {
                            _index--;
                            Apply(frames[_index]);
                        }
                        else
                        {
                            _playingOneShot = false;
                            _playOnceReverse = false;
                            if (resetToStartAfterPlayOnce)
                            {
                                _index = startingFrameIndex;
                                Apply(frames[_index]);
                            }
                            OnPlayOnceComplete?.Invoke();
                        }
                    }
                }

                return; // Skip normal looping
            }

            // Handle looping playback
            int index = _index;
            if (Application.isPlaying && _flip < Time.time)
            {
                index++;
                if (index >= frameCount) index = 0;
            }

            if (index != _index || _setGif != Gif)
            {
                _index = index;
                Apply(frames[_index]);
            }
        }

        private void Apply(GifFrame frame)
        {
            Image image = null;
            if (TryGetComponent<SpriteRenderer>(out var spriteRenderer) || TryGetComponent(out image))
            {
                _flip = Time.time + frame.DelayInMs * 0.001f;

                if (spriteRenderer != null) spriteRenderer.sprite = frame.Sprite;
                else if (image != null) image.sprite = frame.Sprite;

                _setGif = Gif;
            }
        }

        public void PlayOnceForward()
        {
            if (Gif == null || Gif.Frames == null || Gif.Frames.Count == 0) return;
            _playOnceForward = true;
            _playOnceReverse = false;
            _playingOneShot = true;
            _index = 0;
            Apply(Gif.Frames[_index]);
        }

        public void PlayOnceReverse()
        {
            if (Gif == null || Gif.Frames == null || Gif.Frames.Count == 0) return;
            _playOnceForward = false;
            _playOnceReverse = true;
            _playingOneShot = true;
            _index = Gif.Frames.Count - 1;
            Apply(Gif.Frames[_index]);
        }
    }
}
