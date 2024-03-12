namespace TestaException
{
    public class TryCatch
    {
        public static void FazTryCatch<T>(Action<T> action, T parametro)
        {
            try
            {
                action(parametro);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}