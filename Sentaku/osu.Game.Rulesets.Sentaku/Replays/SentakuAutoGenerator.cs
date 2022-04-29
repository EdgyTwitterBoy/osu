// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Game.Beatmaps;
using osu.Game.Rulesets.Sentaku.Objects;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Sentaku.Replays
{
    public class SentakuAutoGenerator : AutoGenerator<SentakuReplayFrame>
    {
        public new Beatmap<SentakuHitObject> Beatmap => (Beatmap<SentakuHitObject>)base.Beatmap;

        public SentakuAutoGenerator(IBeatmap beatmap)
            : base(beatmap)
        {
        }

        protected override void GenerateFrames()
        {
            Frames.Add(new SentakuReplayFrame());

            foreach (SentakuHitObject hitObject in Beatmap.HitObjects)
            {
                Frames.Add(new SentakuReplayFrame
                {
                    Time = hitObject.StartTime
                    // todo: add required inputs and extra frames.
                });
            }
        }
    }
}
