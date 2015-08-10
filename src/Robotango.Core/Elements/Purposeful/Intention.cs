// Robotango (c) 2015 Krokodev
// Robotango.Core
// Intention.cs

using Robotango.Core.Elements.Active;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Elements.Purposeful
{
    public class Intention : IIntention
    {
        private readonly IOperation _operation;

        public Intention( IOperation operation )
        {
            _operation = operation;
        }

        public void Execute( IReality reality )
        {
            _operation.Execute( reality );
        }
    }
}