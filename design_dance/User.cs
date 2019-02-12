using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_dance
{
    class User
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("username")]
        public String mUsername { get; set; }
        [BsonElement("password")]
        public String mPass { get; set; }

        public User(string username, string password)
        {
            this.mUsername = username;
            this.mPass = password;
        }
    }
}
