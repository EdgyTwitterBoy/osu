// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Sentaku.Objects;
using osu.Game.Rulesets.Sentaku.Objects.Drawables;
using osu.Game.Rulesets.Sentaku.Replays;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.UI.Scrolling;

namespace osu.Game.Rulesets.Sentaku.UI
{
    [Cached]
    public class DrawableSentakuRuleset : DrawableScrollingRuleset<SentakuHitObject>
    {
        public DrawableSentakuRuleset(SentakuRuleset ruleset, IBeatmap beatmap, IReadOnlyList<Mod> mods = null)
            : base(ruleset, beatmap, mods)
        {
            Direction.Value = ScrollingDirection.Left;
            TimeRange.Value = 6000;
        }

        protected override Playfield CreatePlayfield() => new SentakuPlayfield();

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new SentakuFramedReplayInputHandler(replay);

        public override DrawableHitObject<SentakuHitObject> CreateDrawableRepresentation(SentakuHitObject h) => new SentakuNote(h);

        protected override PassThroughInputManager CreateInputManager() => new SentakuInputManager(Ruleset?.RulesetInfo);
    }
}
