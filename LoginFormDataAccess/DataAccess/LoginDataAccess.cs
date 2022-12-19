using LoginFormDataAccess.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Security;

namespace LoginFormDataAccess.DataAccess
{
    public class LoginDataAccess
    {
        
        private const string ConnectionString = "mongodb+srv://seed:seed123@cluster0.oqrsjha.mongodb.net/test";    // Local MongoDb Server
        private const string Database = "Seed";      // Database to connect to. Does not have to already exist, will be created when called upon first time.
        private const string UserCollection = "User";      // Document collection; users. Does not have to already exist either, same as above.
 
        /// <summary>
        /// Connection to Mongodb to the collection supplied. 
        /// Generic, any Model type can be added.
        /// </summary>
        /// <typeparam name="T">Collection type (Model class)</typeparam>
        /// <param name="collection">Collection of documents</param>
        /// <returns>Collection of the type specified</returns>
        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(Database);
            return db.GetCollection<T>(collection);
        }

        /// <summary>
        /// Create a user that is stored on the MongoDb Server
        /// </summary>
        /// <param name="user">User to create. Can be created by instantiated a new UserModel class</param>
        /// <returns>User added to the database</returns>
        public Task CreateUser(UserModel user)
        {
            user.Password = HashPassword(user.Password);
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            return usersCollection.InsertOneAsync(user);
        }

        /// <summary>
        /// Update user record
        /// </summary>
        /// <param name="user">User to update.</param>
        /// <returns>Replaces the current user in the database with the updated user information</returns>
        public Task UpdateUser(UserModel user)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var filter = Builders<UserModel>.Filter.Eq("Id", user.Id);
            return usersCollection.ReplaceOneAsync(filter, user);
        }

        /// <summary>
        /// Tries to fetch a user with the specified user id.
        /// </summary>
        /// <param name="userId">User id used to find user</param>
        /// <returns>UserModel object (a user)</returns>
        public UserModel GetUserFromId(string userId)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var user = usersCollection.Find(u => u.Id == userId).FirstOrDefault();
            return user;
        }

        public bool UsernameIsAvailable(string email)
        {
            bool output = true;
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var user = usersCollection.Find(u => u.Email == email).FirstOrDefault();
            if (user != null)
            {
                output = false;
            }

            return output;
        }

        /// <summary>
        /// Attempts to get a user from the supplied username, while at the same time returning a bool
        /// specifying if the operation was successful or if the user returned was null
        /// </summary>
        /// <param name="email">Username used to try to find user in the database</param>
        /// <returns>UserModel object and a bool specifying if user was found or if null was returned</returns>
        public (UserModel user, bool isValid) GetUserFromUsername(string email)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var user = usersCollection.Find(u => u.Email == email).FirstOrDefault();
            bool validUser = false;
            if (user != null)
            {
                validUser = true;
            }
            return (user, validUser);
        }

        /// <summary>
        /// Checks if the supplied password matches the password of the user during a login attempt.
        /// </summary>
        /// <param name="user">User to check password against.</param>
        /// <param name="password">Input password</param>
        /// <returns>If the input password matches the password of the user in the database.</returns>
        public bool ValidatePassword(UserModel user, string password)
        {
            bool output = false;

            if(user?.Password == HashPassword(password))  // If user is null, operation short citcuits at ? and this expression returns false.
                                            // This to prevent a null reference exception crash.
            {
                output = true;
            }

            return output;
        }

        public bool ValidateComputerId(UserModel user, string deviceId)
        {
            bool output = false;

            if (user?.ComputerId == deviceId)  // If user is null, operation short citcuits at ? and this expression returns false.
                                                           // This to prevent a null reference exception crash.
            {
                output = true;
            }

            return output;
        }

        public string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encripted_bytes = sha1.ComputeHash(password_bytes);

            return Convert.ToBase64String(encripted_bytes);
        }
    }
}
