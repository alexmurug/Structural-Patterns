//Refernece: System.Web.Extensions

using AdapterPattern.Target;
using Newtonsoft.Json;

namespace AdapterPattern.Adapters
{
    public class JsonSerializerAdapter : ISerializerAdapter
    {
        public string Serialize<T>(object objToSerialize)
        {
            var serializedString = JsonConvert.SerializeObject(objToSerialize);
            return serializedString;
        }
    }
}