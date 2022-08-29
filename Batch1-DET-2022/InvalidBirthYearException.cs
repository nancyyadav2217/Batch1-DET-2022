﻿using System.Runtime.Serialization;

namespace Batch1_DET_2022
{
    [Serializable]
    internal class InvalidBirthYearException : Exception
    {
        public InvalidBirthYearException()
        {
        }

        public InvalidBirthYearException(string? message) : base(message)
        {
        }

        public InvalidBirthYearException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidBirthYearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}