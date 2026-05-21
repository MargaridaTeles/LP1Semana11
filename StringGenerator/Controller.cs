using System;
using System.Text;

namespace StringGenerator
{
    public class Controller
    {
        private const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string Generate(Model model, int length = 16)
        {
            Random rng = new Random(model.Seed);

            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = rng.Next(chars.Length);
                result.Append(chars[index]);
            }

            return result.ToString();
        }
    }
}