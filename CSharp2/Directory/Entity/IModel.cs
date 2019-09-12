using System.Collections.Generic;

namespace Entity
{
    public interface IModel
    {
        int Id { get; }
        List<string> Properties { get; }
    }
}
