namespace Collection
{
    public class SuperObject
    {
        public string Name { get; set; }
        
        public int ID { get; set; }

        public SuperObject()
        {
            Name = "???";
            ID = 00;
        }
        
        public SuperObject(string _name,int _id)
        {
            Name = _name;
            ID = _id;
        }
    }
}