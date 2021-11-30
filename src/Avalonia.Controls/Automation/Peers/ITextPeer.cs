﻿using System.Collections.Generic;

#nullable enable

namespace Avalonia.Automation.Peers
{
    /// <summary>
    /// Internal interface used by <see cref="AutomationTextRange"/> to communicate with its peer.
    /// </summary>
    internal interface ITextPeer
    {
        /// <summary>
        /// Gets a value indicating whether the text is read-only.
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Gets the number of lines of text; always >= 1.
        /// </summary>
        int LineCount { get; }

        /// <summary>
        /// Gets the control's text.
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Retrieves a collection of bounding rectangles for each fully or partially visible line
        /// of text in a text range.
        /// </summary>
        /// <param name="start">The start of the text range.</param>
        /// <param name="end">The exclusive end of the text range.</param>
        /// <returns>A collection of <see cref="Rect"/>s in top-level coordinates.</returns>
        IReadOnlyList<Rect> GetBounds(int start, int end);

        /// <summary>
        /// Gets the line number for the specified character position.
        /// </summary>
        /// <param name="charIndex">The character index.</param>
        /// <returns>The line number.</returns>
        int LineFromChar(int charIndex);

        /// <summary>
        /// Gets the character index for the start of the specified line.
        /// </summary>
        /// <param name="lineIndex">The index of the line.</param>
        /// <returns>The character index.</returns>
        int LineIndex(int lineIndex);
    }
}