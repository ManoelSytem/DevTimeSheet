using TimeSheet.Domain.Proxy;

namespace TimeSheet.Domain
{
    public class FluigProcess
    {
        public FluigProcess()
        {
            AppointmentFluig = new processTaskAppointmentDto[] { };
            AttachmentsFluig = new processAttachmentDto[] { };
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
        public string IdProcesso { get; set; }
        public int Atividade { get; set; }
        public string[] ColleagueId { get; set; }
        public bool Completatarefa { get; set; }
        public string Attachments { get; set; }
        public string[][] CardData { get; set; }
        public string Appointment { get; set; }
        public string Comment { get; set; }
        public bool Gestor { get; set; }
        public string UserCordFluig { get; set; }
        public processTaskAppointmentDto[] AppointmentFluig { get; set; }
        public processAttachmentDto[] AttachmentsFluig { get; set; }

    }
}
