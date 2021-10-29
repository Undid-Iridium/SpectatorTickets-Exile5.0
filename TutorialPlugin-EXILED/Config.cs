﻿using System.Collections.Generic;
using System.ComponentModel;

using Exiled.API.Features;
using Exiled.API.Interfaces;

using UnityEngine;
namespace TutorialPlugin_EXILED
{
    public sealed class Config : IConfig
    {
        //public bool IsEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEnabled { get; set; } = true;


        [Description("Sets the message when someone joins the server. {Player} will be replaced with player name.")]
        public string JoinMessage { get; set; } = "{Player} - Why would you join?";

        [Description("Sets the message when someone Leaves the server. {Player} will be replaced with player name.")]
        public string LeaveMessage { get; set; } = "{Player} - Good riddance, and don't come back!";

        [Description("Sets the message when the rounds starts.")]
        public string RoundStartMessage { get; set; } = "Time to die!";


        [Description("Sets the message when a booby trapped door is touched")]
        public string DoorTrapMessage { get; set; } = "My trap door is activated My trap has been activated!!";


        ///// <summary>
        ///// Gets the joined broadcast.
        ///// </summary>
        //[Description("This is an example on how to use the Broadcast class, to send a broadcast to joined players")]
        //public Broadcast JoinedBroadcast { get; private set; } = new Broadcast("Welcome to the server!", 15);

    }
}