using System.Runtime.Serialization;

namespace Neolithica.Serialization.Surrogates {
    /// <summary>
    /// Part of the SerializeHelper package by Cherno.
    /// http://forum.unity3d.com/threads/serializehelper-free-save-and-load-utility-de-serialize-all-objects-in-your-scene.338148/
    /// </summary>
    sealed class Texture2DSurrogate : ISerializationSurrogate {
	
        // Method called to serialize a Vector3 object
        public void GetObjectData(System.Object obj,
            SerializationInfo info, StreamingContext context) {
		
            //Texture2D t = (Texture2D) obj;
        }
	
        // Method called to deserialize a Vector3 object
        public object SetObjectData(System.Object obj,
            SerializationInfo info, StreamingContext context,
            ISurrogateSelector selector) {
		
            //Texture2D t = (Texture2D) obj;
            return obj;
        }
    }
}