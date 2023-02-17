using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Assignment1
{
    internal class InvalidWeaponException : Exception
    {

        public InvalidWeaponException()
        {
        }

        public InvalidWeaponException(string? message) : base(message)
        {
        }

        public InvalidWeaponException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidWeaponException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
    internal class InvalidArmorException : Exception
    {

        public InvalidArmorException()
        {
        }

        public InvalidArmorException(string? message) : base(message)
        {
        }

        public InvalidArmorException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidArmorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
