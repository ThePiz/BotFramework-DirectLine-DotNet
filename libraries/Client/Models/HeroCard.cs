﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.

// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.DirectLine
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A Hero card (card with a single, large image)
    /// </summary>
    public partial class HeroCard
    {
        /// <summary>
        /// Initializes a new instance of the HeroCard class.
        /// </summary>
        public HeroCard() { }

        /// <summary>
        /// Initializes a new instance of the HeroCard class.
        /// </summary>
        public HeroCard(string title = default(string), string subtitle = default(string), string text = default(string), IList<CardImage> images = default(IList<CardImage>), IList<CardAction> buttons = default(IList<CardAction>), CardAction tap = default(CardAction))
        {
            Title = title;
            Subtitle = subtitle;
            Text = text;
            Images = images;
            Buttons = buttons;
            Tap = tap;
        }

        /// <summary>
        /// Title of the card
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Subtitle of the card
        /// </summary>
        [JsonProperty(PropertyName = "subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// Text for the card
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Array of images for the card
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<CardImage> Images { get; set; }

        /// <summary>
        /// Set of actions applicable to the current card
        /// </summary>
        [JsonProperty(PropertyName = "buttons")]
        public IList<CardAction> Buttons { get; set; }

        /// <summary>
        /// This action will be activated when user taps on the card itself
        /// </summary>
        [JsonProperty(PropertyName = "tap")]
        public CardAction Tap { get; set; }

    }
}
