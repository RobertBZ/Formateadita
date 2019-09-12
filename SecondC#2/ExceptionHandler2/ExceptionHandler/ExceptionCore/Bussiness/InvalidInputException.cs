namespace ExceptionCore.Bussiness
{
    public class InvalidInputException : BussinesException
    {
        public InvalidInputException(int end) 
            : base(string.Format(
                "Dato introducido no es valido, por favor ingresa un numero entre 1 y {0}", end))
        { }
    }
}
