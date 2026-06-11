namespace MockupVisProg.Models
{
    public abstract class BaseModel
    {
        public abstract int GetID();

        public virtual string GetInfo()
        {
            return string.Format("[{0}] ID={1}", GetType().Name, GetID());
        }
    }
}
