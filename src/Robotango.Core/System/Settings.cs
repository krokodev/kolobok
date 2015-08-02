// Robotango (c) 2015 Krokodev
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
                public const string Imaginary = "Imaginary";
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
                public const string Default = "Some Agent";
            }
        }
    }
}