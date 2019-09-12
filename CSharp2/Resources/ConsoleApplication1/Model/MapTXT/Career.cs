using Model.AbstractModel;

namespace Model.MapTXT
{
    public class Career : AbstractCareer, IModel
    {
        public Career()
        {
            Root = "Carreras.txt";
        }

        public override void ToModel(string str)
        {
            var split = str.Split('/');
            Id = int.Parse(split[0]);
            Code = split[1];
            Name = split[2];
        }      
    }
}
