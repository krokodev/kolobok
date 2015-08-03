﻿// Robotango (c) 2015 Krokodev
// Robotango.Core
// Settings.cs

namespace Robotango.Core.System
{
    public static class Settings
    {
        public static class Reality
        {
            public static class Names
            {
                public const string FullTemplate = "{0}.{1}";
                public const string FamilyTemplate = "{0}'{1}.{2}";
                public const string Default = "Some Reality";
            }
        }

        public static class Agents
        {
            public static class Rational
            {
                public static class InnerReality
                {
                    public const string Name = "Imaginary";
                }
            }

            public static class Names
            {
                public const string FullTemplate = "{0}[{1}]";
                public const string Default = "Some Agent";
            }
        }

        public static class Worlds
        {
            public static class Names
            {
                public const string Default = "Some World";
            }
        }

        public static class Depth
        {
            public const uint Basic = 0;
        }
    }
}