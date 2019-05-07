using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Создать новый пол
        /// </summary>
        /// <param name="name"></param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Пол не может быть пустым", nameof(name));
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
