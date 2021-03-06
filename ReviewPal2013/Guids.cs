﻿// Guids.cs
// MUST match guids.h
using System;

namespace ReviewPal.ReviewPal2012
{
    static class GuidList
    {
        public const string guidReviewPal2012PkgString = "ee7f04d0-2831-48bb-9053-a2e8df3acb4b";
        public const string guidReviewPal2012CmdSetString = "1f003d1f-1c75-41e4-8c2c-0901fb4fcdcc";
        public const string guidToolWindowPersistanceString = "404ce4ad-144c-402c-be54-ec7768c6d813";

        public static readonly Guid guidReviewPal2012CmdSet = new Guid(guidReviewPal2012CmdSetString);
    };
}