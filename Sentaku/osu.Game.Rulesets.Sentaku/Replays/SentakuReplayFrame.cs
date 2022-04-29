// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;

namespace osu.Game.Rulesets.Sentaku.Replays
{
    public class SentakuReplayFrame : ReplayFrame
    {
        public List<SentakuAction> Actions = new List<SentakuAction>();

        public SentakuReplayFrame(SentakuAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
