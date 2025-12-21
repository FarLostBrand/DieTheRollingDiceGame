using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace CoreLibrary;

#nullable enable

/// <summary>
/// Represents the state of an entity, object, etc.
/// </summary>
public abstract class State
{
    /// <summary>
    /// Called when entering this State.
    /// </summary>
    /// <param name="parameters">Optional parameters needed from other states.</param>
    public virtual void Enter(Dictionary<string, object>? parameters = null) { }

    /// <summary>
    /// Called when exiting this State.
    /// </summary>
    public virtual void Exit() { }

    /// <summary>
    /// Called every GameTime while this state is active.
    /// </summary>
    /// <param name="gameTime">The GameTime of the game.</param>
    public virtual void Update(GameTime gameTime) { }

    /// <summary>
    /// Called every GameTime while this state is active.
    /// </summary>
    /// <param name="gameTime">The GameTime of the game.</param>
    public virtual void Draw(GameTime gameTime) { }
}

