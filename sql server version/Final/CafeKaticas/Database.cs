using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CafeKaticas
{
    class Database
    {
        private MongoClient client;
        private IMongoDatabase database;

        public Database()
        {
            string connectionString = "mongodb://localhost:27017/";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("ATV");
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return database.GetCollection<BsonDocument>(collectionName);
        }

        public List<BsonDocument> Find(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            var collection = GetCollection(collectionName);
            return collection.Find(filter).ToList();
        }

        public void Insert(string collectionName, BsonDocument document)
        {
            var collection = GetCollection(collectionName);
            collection.InsertOne(document);
        }

        public void Update(string collectionName, FilterDefinition<BsonDocument> filter, UpdateDefinition<BsonDocument> update)
        {
            var collection = GetCollection(collectionName);
            collection.UpdateOne(filter, update);
        }

        public void Delete(string collectionName, FilterDefinition<BsonDocument> filter)
        {
            var collection = GetCollection(collectionName);
            collection.DeleteOne(filter);
        }

        public List<BsonDocument> GetAll(string collectionName)
        {
            var collection = GetCollection(collectionName);
            return collection.Find(new BsonDocument()).ToList();
        }

        public long CountDocuments(string collectionName, FilterDefinition<BsonDocument> filter = null)
        {
            var collection = GetCollection(collectionName);
            return collection.CountDocuments(filter ?? new BsonDocument());
        }
    }
}
