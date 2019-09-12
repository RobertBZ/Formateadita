using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IModel
    {
        int Id { get; set; }
        string Root { get; set; }
        void ToModel(string str);
    }
}
