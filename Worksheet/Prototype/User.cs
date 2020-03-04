
using System.Text;
using static QuestionFour.Access;
namespace QuestionFour
{
    public class User
    {
        public string UserName { get; set; }
        public string Level { get; set; }
        public Access AccessControl { get; set; }

        public User(string name, string level, AccessControl userAccessControl)
        {
            UserName = name;
            Level = level;
            AccessControl = userAccessControl.Access;
        }
        public override string ToString() => new StringBuilder()
            //.Append($"-------------- {CarType} --------------------- \n")
            .Append($" Name: {UserName}, ")
            .Append($" Level: {Level}, ")
            .Append($" Access Control Level: {AccessControl.GetUIFriendlyString()}\n")
            .ToString();
    }

    public static class Ext{
                 public static string GetUIFriendlyString(this Access access)
                    {
                        switch ((int)access)
                        {
                            case 2:
                                return "GENERATE\\READ REPORTS";
                            case 1: 
                                return "READ REPORTS";
                          default:
                             return "DO_WORK";
                        }
                    }
             }


}

   
 