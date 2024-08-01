
using System.Security.Cryptography.X509Certificates;

namespace P27_AccesMods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Public = 1;
            human.Private = 2; // Error: 'Human.Private' is inaccessible due to its protection level
            human.Protected = 3; // Error: 'Human.Protected' is inaccessible due to its protection level
            human.Internal = 4;
            human.ProtectedInternal = 5;
            human.PrivateProtected = 6; // Error: 'Human.PrivateProtected' is inaccessible due to its protection level
        }
    }
}
