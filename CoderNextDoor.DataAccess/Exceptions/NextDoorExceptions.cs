using System;

namespace CoderNextDoor.DataAccess.Exceptions
{
    public class NextDoorExceptions : Exception
    {
        /// <summary>
        /// Thrown when <see cref="ValidationResult.IsValid"/> is false.
        /// </summary>
        /// <param name="message">Summary of what's happening</param>
        /// <param name="result">Individual errors inside the result</param>
        //public FanException(string message, IList<ValidationFailure> validationFailures)
        //    : base(message)
        //{
        //    ValidationErrors = validationFailures;
        //    ExceptionType = EExceptionType.ValidationError;
        //}
    }
}