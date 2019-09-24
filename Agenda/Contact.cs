using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    // Pentru a adauga acest fisier faceti click dreapta pe proiect (In solution explorer al doilea dreptunghi)
    // Si adaugati o clasa.
    class Contact
    {
        // Doua propietati de tip String. Asa se fac geterii si seterii in C# (pronuntat c sharp)
        public String Name { get; set; }
        public String Phone { get; set; }

        // Constructorul clasei. Aici se initializeaza propietatile.
        public Contact(String Name, String Phone)
        {
            this.Name = Name;
            this.Phone = Phone;
        }
    }
}
