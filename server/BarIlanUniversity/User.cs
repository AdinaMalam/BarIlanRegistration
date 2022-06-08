namespace BarIlanUniversity
{
    public class User
    {

        public int IUserId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int ILastModifyUserId { get; set; }
        public DateTime DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public string NvUserName { get; set; } = null!;
        public string password { get; set; } = null!;
        public int IInstitutionId { get; set; }
        public int IInstitutionUserRoleId { get; set; }
     
    }
}
