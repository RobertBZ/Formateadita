namespace Model.MapTXT
{
    public class CareerMap : AbstractMap
    {
        public CareerMap()
        {
            Root = "Carreras.txt";
        }

        public override IModel ToModel(string str)
        {
            var split = str.Split('/');
            return new Career
            {
                Id = int.Parse(split[0]),
                Code = split[1],
                Name = split[2]
            };
        }      
    }
}
