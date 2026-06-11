using System;

namespace MockupVisProg.Models
{
    public class User : BaseModel
    {
        public int      UserID    { get; set; }
        public string   Username  { get; set; }
        public string   Email     { get; set; }
        public string   Password  { get; set; }
        public DateTime CreatedAt { get; set; }

        public override int GetID() => UserID;

        public override string GetInfo()
        {
            return string.Format("[User] {0} <{1}>", Username, Email);
        }
    }
}
