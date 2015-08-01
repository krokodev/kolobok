// Robotango (c) 2015 Krokodev
// Robotango.Core
// Answer.cs

using Robotango.Core.Types.Communications;
using Robotango.Core.Types.Components;
using Robotango.Core.Types.Skills;

namespace Robotango.Core.Implements.Communications
{
    internal struct Answer<T> : IAnswer< T >
    {
        public IQuestion< T > Question { get; set; }
        public ISocial Respondent { get; set; }
        public IAnswerResult< T > Result { get; set; }
    }
}