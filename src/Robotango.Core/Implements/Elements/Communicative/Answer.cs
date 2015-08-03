// Robotango (c) 2015 Krokodev
// Robotango.Core
// Answer.cs

using Robotango.Core.Types.Abilities;
using Robotango.Core.Types.Elements.Communicative;

namespace Robotango.Core.Implements.Elements.Communicative
{
    internal struct Answer<T> : IAnswer< T >
    {
        public IQuestion< T > Question { get; set; }
        public IRespondent Respondent { get; set; }
        public IAnswerResult< T > Result { get; set; }
    }
}