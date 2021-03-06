﻿namespace ShowerTimer.Core
{
    using System;
    using Windows.Media.Core;

    public class ConditionerTimeSequence : SequenceBase, IActionSequence
    {
        public ConditionerTimeSequence(TimeSpan targetPlayTime)
            : base(targetPlayTime)
        {
        }

        public string SequenceName => "Conditioner";

        private AudioComponent Audio => new AudioComponent(MediaSource.CreateFromUri(new Uri("ms-appx:///Cues/conditioner.mp3")));

        public void Run()
        {
            this.Audio.Play();
        }

        public void Abort()
        {
            this.Audio.Pause();
        }
    }
}
