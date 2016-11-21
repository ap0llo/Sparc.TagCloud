using System;
using System.Runtime.Serialization;
using LemmaSharp;

namespace Sparc.TagCloud
{
    public class NullLemmatizer : ILemmatizer
    {
        public string Lemmatize(string sWord) => sWord;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // no state to serialize
        }
    }
}