﻿namespace AsterNET.Manager.Event
{

    /// <summary>
    ///     Raised when an Asterisk service sends an authentication challenge to a request.
    ///     
    ///     See <see target="_blank"  href="https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_ChallengeSent">https://wiki.asterisk.org/wiki/display/AST/Asterisk+16+ManagerEvent_ChallengeSent</see>
    /// </summary>
    public class ChallengeSentEvent : ManagerEvent
    {
        /// <summary>
        ///     Creates a new <see cref="ChallengeSentEvent"/> using the given <see cref="ManagerConnection"/>.
        /// </summary>
        /// <param name="source"></param>
        public ChallengeSentEvent(ManagerConnection source) : base(source)
        {
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string Status { get; set; }
    }
}