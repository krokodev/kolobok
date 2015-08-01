﻿// Robotango (c) 2015 Krokodev
// Robotango.Core
// Constants.cs

namespace Robotango.Core.Common
{
    public static class Constants
    {
        public static class Worlds
        {
            public static class Names
            {
                public const string FullTemplate = "{0}.{1}";
                public const string FamilyTemplate = "{0}'{1}.{2}";
                public const string Default = "Some world";
                public const string Imaginary = "Img";
            }
        }

        public static class Depth
        {
            public const uint Basic = 0;
        }

        public static class Agents
        {
            public static class Names
            {
                public const string FullTemplate = "{0}[{1}]";
                public const string Default = "Agent";
            }
        }
    }
}