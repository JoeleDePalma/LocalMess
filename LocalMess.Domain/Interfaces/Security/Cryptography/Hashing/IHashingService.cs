using System;
using System.Collections.Generic;
using System.Text;

namespace LocalMess.Domain.Interfaces.Security.Cryptography.Hashing
{
    public interface IHashingService
    {
        (byte[] Hash, byte[] Salt) Hash(byte[] plainText, byte[]? salt = null);
    }
}
