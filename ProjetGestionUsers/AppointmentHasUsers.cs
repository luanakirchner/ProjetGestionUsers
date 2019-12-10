using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionUsers
{
    class AppointmentHasUsers
    {
        private long id;
        private Appointment idAppointment;
        private Users idUsers;

        public long Id { get => id; set => id = value; }
        internal Appointment IdAppointment { get => idAppointment; set => idAppointment = value; }
        internal Users IdUsers { get => idUsers; set => idUsers = value; }
    }
}
