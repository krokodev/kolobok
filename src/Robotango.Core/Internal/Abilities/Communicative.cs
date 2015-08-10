// Robotango (c) 2015 Krokodev
// Robotango.Core
// Communicative.cs

using System;
using Robotango.Common.Domain.Types.Compositions;
using Robotango.Core.Elements.Communicative;
using Robotango.Core.Interfaces.Abilities;
using Robotango.Core.Interfaces.Agency;

namespace Robotango.Core.Internal.Abilities
{
    internal class Communicative : ICommunicative
    {
        #region IComponent

        void IComponent.InitReferences( IComposite composition )
        {
            Thinking = composition.GetComponent< IThinking >();
        }

        IComponent IComponent.Clone()
        {
            return new Communicative();
        }

        #endregion


        #region IQuerist

        IQuestion< T > IQuerist.Ask<T>( Func< IReality, T > theme )
        {
            return new Question< T > {
                Querist = this,
                Essense = theme
            };
        }

        #endregion


        #region IRespondent

        IAnswer< T > IRespondent.Reply<T>( IQuestion< T > question )
        {
            return new Answer< T > {
                Question = question,
                Respondent = this,
                Result = ComputeAnswerResult( question ),
            };
        }

        #endregion


        #region Fields

        private IThinking Thinking { get; set; }

        #endregion


        #region Routines

        private IAnswerResult< T > ComputeAnswerResult<T>( IQuestion< T > question )
        {
            var result = new AnswerResult< T >();
            try {
                result.Value = question.Essense.Invoke( GetWorldForAnswer() );
                result.IsVaild = true;
            }
            catch( Exception exception ) {
                result.IsVaild = false;
                result.Exception = exception;
            }

            return result;
        }

        private IReality GetWorldForAnswer()
        {
            return Thinking == null ? null : Thinking.InnerReality;
        }

        #endregion
    }
}