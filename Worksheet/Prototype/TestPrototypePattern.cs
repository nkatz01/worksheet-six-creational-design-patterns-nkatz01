using System;

namespace QuestionFour
{
    public static class TestPrototypePattern
    {
        public static void Main(string[] args)
        {
            var userAccessControl = AccessControlProvider.GetAccessControlObject("USER");
            var user = new User("User A", "USER Level", userAccessControl);

            Console.WriteLine("************************************");
            Console.WriteLine(user);

            userAccessControl = AccessControlProvider.GetAccessControlObject("USER");
            user = new User("User B", "USER Level", userAccessControl);
            Console.WriteLine($"Changing access control of: {user.UserName}");
            user.AccessControl.Access = Access.ReadReports;
            Console.WriteLine(user);

            //Console.WriteLine("************************************");
            //userAccessControl = AccessControlProvider.GetAccessControlObject("USER");
            //var user1 = new User("User C", "USER Level", userAccessControl);
            //Console.WriteLine($"Changing access control of: {user1.UserName}");
            //user1.AccessControl = Access.Generate;
            //Console.WriteLine($"if ACP doesn't clone, then user's permmisions have also changed to modify: {user.UserName}" + "has " + $" { user}");


            Console.WriteLine("************************************");

            AccessControl managerAccessControl = AccessControlProvider.GetAccessControlObject("MANAGER");
            user = new User("User C", "MANAGER Level", managerAccessControl);
            Console.WriteLine(user);
        }
    }
}