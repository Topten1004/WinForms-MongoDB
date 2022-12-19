using LoginFormDataAccess.DataAccess;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace LoginFormDataAccess.Models
{
    public class TwaatModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public string OriginalContent { get; private set; }     // to be able to see what the original post was
        public DateTime TimeOfPosting { get; set; }
        public DateTime LastEdited { get; set; }
        public bool PostHasBeenEdited { get; set; } = false;

        public TwaatModel()
        {

        }

        public TwaatModel(string originalContent)
        {
            OriginalContent = originalContent;
        }
    }
}
