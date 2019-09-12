using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.MapTXT
{
    public class ProfessorMap : AbstractMap
    {
        public ProfessorMap()
        {
            Root = "Docente.txt";
        }

        public override IModel ToModel(string str)
        {
            var split = str.Split('-');
            return new Professor
            {
                Id = int.Parse(split[0]),
                Name = split[1],
                Lastname = split[2],
                Code = split[3]
            };
        }
    }
}
